using cernyjack.Data;
using cernyjack.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace cernyjack.Services
{
    public class BusinessLogic : IBusinessLogic
    {
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _hca;
        public BusinessLogic(ApplicationDbContext db, IHttpContextAccessor hca)
        {
            _db = db;
            _hca = hca;
        }
        public IList<Card> Deal(string userId = "")
        {
            if (userId == "") 
            { 
            userId = GetUserId();
            }
            IList<UserCard> userCardList =_db.UserCards.Where(x => x.UserId == userId)
                .Include(y => y.Card)
                .AsNoTracking()
                .ToList();
            IList<Card> result = new List<Card>();
            Random random = new Random();
            int randomone = random.Next(1, 52);
            var firstCard = new UserCard()
            {
                UserId = userId,
                CardId = randomone
            };
            _db.UserCards.Add(firstCard);
            Card cardOne = _db.Cards.Where(x => x.Id == randomone)
                .AsNoTracking()
                .FirstOrDefault();
            result.Add(cardOne);
            if (!userCardList.Any())
            {           
                int randomtwo = random.Next(1,52);
                var secondCard = new UserCard()
                {
                    UserId = userId,
                    CardId = randomtwo
                };
                _db.UserCards.Add(secondCard);
                Card cardTwo = _db.Cards.Where(x => x.Id == randomtwo)
                .AsNoTracking()
                .FirstOrDefault();
                result.Add(cardTwo);
            }
            foreach(var item in userCardList)
            {
                result.Add(item.Card);        
            }
            _db.SaveChanges();
            return result;

        }

        public void EndGame()
        {
            string userId = GetUserId();
            _db.UserCards.RemoveRange(_db.UserCards.Where(x => x.UserId == userId));
            _db.SaveChanges();
        }

        public string GetUserId()
        {
            var userId = _hca.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return userId.ToString();
        }
        
    }
}
