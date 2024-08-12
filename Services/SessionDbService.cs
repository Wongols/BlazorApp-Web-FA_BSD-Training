using BlazorApp_FA_BSD_Training.Data;
using BlazorApp_FA_BSD_Training.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace BlazorApp_FA_BSD_Training.Services
{
    public interface ISessionDbService
    {
        Task<List<Session>> GetSessions();
        Task<Session> GetSessionById(int id);
        Task<Session> AddSession(Session session);
        Task<Session> EditSession(Session session);
        Task<Session> DeleteSession(int id);

    }

    public class SessionDbService : ISessionDbService

    {
        private readonly ApplicationDbContext? _context;
        public SessionDbService(ApplicationDbContext context)

        {
            _context = context;

        }

        public async Task<List<Session>> GetSessions()
        {
            return await _context.Sessions.ToListAsync();
        }

        public async Task<Session> GetSessionById(int id)
        {
            var session = await _context.Sessions.FindAsync(id);
            return session;
        }


        public async Task<Session> AddSession(Session session)
        {
            _context.Sessions.Add(session);
            await _context.SaveChangesAsync();
            return session;
        }

        public async Task<Session> EditSession(Session session)
        {
            _context.Entry(session).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return session;
        }


        public async Task<Session> DeleteSession(int id)
        {
            var session = await _context.Sessions.FindAsync(id);
            _context.Sessions.Remove(session);
            await _context.SaveChangesAsync();
            return session;
        }

      
     

     
    }


}
