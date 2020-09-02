using System.Threading.Tasks;
using BusPass.Server.Repository;
using BusPass.Shared.Entities;
using System.Collections.Generic;
using BusPass.Shared.HelperEntities;
using System;

namespace BusPass.Server.Services {
    public class BusPassportService : IBusPassportService {
        private readonly IBusPassportRepository _repo;

        public BusPassportService (IBusPassportRepository repo) {
            _repo = repo;
        }

        public async Task<bool> createBussPassport (BusPassport pass) {
            pass.DateOfIssue = DateTime.Today;
            pass.Valid = true;
            return await _repo.createBussPassport (pass);
        }

        public async Task<BusPassport> getBusPassport (int busPassId) {
            return await _repo.getBusPassport (busPassId);
        }

        public async Task<BusPassport> makeInvalid (int passId) {
            BusPassport busPass = await _repo.getBusPassport (passId);
            if (busPass == null || busPass.Valid == false) {
                return null;
            } else {
                busPass.Valid = false;
                return await _repo.changeValidity (busPass);
            }
        }

        public async Task<BusPassport> makeValid (int passId) {
            BusPassport busPass = await _repo.getBusPassport (passId);
            if (busPass == null || busPass.Valid == true) {
                return null;
            } else {
                busPass.Valid = true;
                busPass.DateOfIssue = DateTime.Today;
                return await _repo.changeValidity (busPass);
            }
        }

        public async Task<ICollection<BusPassport>> getBusPassports (bool valid) {
            return await _repo.getBusPassports(valid);
        }

        public async Task<ICollection<UserBusPassport>> getBusPassportByType (int passTypeId, bool valid) {
            return await _repo.getBusPassportByType(passTypeId, valid);
        }
    }
}