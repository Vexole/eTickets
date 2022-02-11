using eTickets.Data;
using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Services
{
    public class ActorService : BaseEntityRepository<Actor>, IActorService
    {
        public ActorService(ApplicationDbContext context) : base(context)
        {
            
        }

      /*  public async Task AddActorAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteActorAsync(int id)
        {
            var actor = await _context.Actors.FirstOrDefaultAsync(actor => actor.Id == id);
            _context.Actors.Remove(actor);
            await _context.SaveChangesAsync();
        }

        public async Task<Actor> GetActorByIdAsync(int id)
        {
            return await _context.Actors.FirstOrDefaultAsync(actor => actor.Id == id);
        }

        public async Task<IEnumerable<Actor>> GetAllActorsAsync()
        {
            return await _context.Actors.ToListAsync();
        }

        public async Task<Actor> UpdateActorAsync(int id, Actor actor)
        {
            _context.Actors.Update(actor);
            await _context.SaveChangesAsync();
            return actor;
        }*/
    }
}
