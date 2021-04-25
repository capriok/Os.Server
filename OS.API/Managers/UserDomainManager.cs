﻿using OS.API.Managers.Interfaces;
using OS.API.Models.User;
using OS.Data.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OS.API.Managers
{
    public class UserDomainManager : IUserDomainManager
    {
        private readonly IUserDomainRepository _UserDomainRepository;

        public UserDomainManager(IUserDomainRepository userDomainRepository)
        {
            _UserDomainRepository = userDomainRepository;
        }

        public async Task<List<UserDomainModel>> GetAllByUserId(int userId)
        {
            var dbUserdomains = await _UserDomainRepository.FindByUserIdQuery(userId);

            var userDomains = new List<UserDomainModel>();

            if (dbUserdomains.Count <= 0)
            {
                return userDomains;
            }

            foreach (var domain in dbUserdomains)
            {
                userDomains.Add(new UserDomainModel(domain.Id)
                {
                    Domain = domain.Domain,
                    UserId = domain.UserId
                });
            }
            return userDomains;
        }
    }
}
