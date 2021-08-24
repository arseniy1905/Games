namespace Games.ViewModel.MVC
{
    public class UserInfoStageItemViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string StepNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsStageCompleted { get; set; }
        public int StageStatusId { get; set; }
        public int StatusId { get; set; }

    }
}
