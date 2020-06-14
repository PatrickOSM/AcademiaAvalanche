using System.Collections.Generic;
using System.Linq;

namespace AcademiaAvalanche.Data
{
    public class TrainerService
    {
        private readonly ApplicationDbContext _db;

        public TrainerService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<TrainerInfo> GetTrainer()
        {
            var trainerList = _db.Trainers.ToList();
            return trainerList;
        }

        public string Create(TrainerInfo objTrainer)
        {
            _db.Trainers.Add(objTrainer);
            _db.SaveChanges();
            return "Save Successfully";
        }

        public TrainerInfo GetTrainerById(int id)
        {
            TrainerInfo trainer = _db.Trainers.SingleOrDefault(x => x.TrainerId == id);
            return trainer;
        }

        public string UpdateTrainer(TrainerInfo objTrainer)
        {
            _db.Trainers.Update(objTrainer);
            _db.SaveChanges();
            return "Update Successfully";
        }

        public string DeleteTrainerInfo(TrainerInfo objTrainer)
        {
            _db.Remove(objTrainer);
            _db.SaveChanges();
            return "Delete Successfully";
        }
    }
}
