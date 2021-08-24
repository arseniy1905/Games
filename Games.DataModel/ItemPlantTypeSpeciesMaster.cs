using System;

namespace Games.DataModel
{
    public class ItemPlantTypeSpeciesMaster
    {
        public int Id { get; set; }
        public string PlantTypeSpecies { get; set; }
        public string PlantTypeSpeciesFr { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
