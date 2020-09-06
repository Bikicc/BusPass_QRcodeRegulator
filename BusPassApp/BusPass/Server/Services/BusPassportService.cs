using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Server.Repository;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;

namespace BusPass.Server.Services {
    public class BusPassportService : IBusPassportService {
        private readonly IBusPassportRepository _repo;
        public BusPassportService (IBusPassportRepository repo, IPassTypeRepository typeRepo) {
            _repo = repo;

        }

        public async Task<bool> createBussPassport (BusPassport pass) {
            pass.DateOfIssue = DateTime.Today;
            pass.Valid = true;
            return await _repo.createBussPassport (pass);
        }

        public async Task<BusPassport> getBusPassport (int userId) {
            return await _repo.getBusPassport (userId);
         }
        public async Task<ICollection<BusPassport>> getBusPassports (bool valid) {
            return await _repo.getBusPassports (valid);
        }

        public async Task<ICollection<UserBusPassport>> getBusPassportByType (int passTypeId, bool valid) {
            return await _repo.getBusPassportByType (passTypeId, valid);
        }

        public async void changePasswordValidityIfExpired () {
            ICollection<BusPassport> busPasses = await _repo.getBusPassports (true);

            foreach (BusPassport pass in busPasses) {
                if (checkIfYearPassed (pass)) {
                    await makeInvalid (pass.BusPassportId);
                }
            }
        }

        private bool checkIfYearPassed (BusPassport pass) {
            return (DateTime.Now - pass.DateOfIssue).TotalDays > 364 ? true : false;
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
    }
}