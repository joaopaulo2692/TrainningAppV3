using TrainningApp.Core.DTO.TrainningExercise;

namespace TrainningAppV3.Client.Service
{
    public class RefreshService
    {
        public event Action RefreshRequested;
        public TrainningExerciseVO TrainningExerciseVO { get; set; }

        public void Execute(TrainningExerciseVO trainningExerciseVO)
        {
            TrainningExerciseVO = trainningExerciseVO;
            RefreshRequested?.Invoke();
        }
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}
