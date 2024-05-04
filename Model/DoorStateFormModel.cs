using System.ComponentModel.DataAnnotations;

namespace ISMTest.Model
{
    public class DoorStateFormModel
    { 
        public Guid? SelectedDoorId { get; set; }

        public string SelectedDoorName { get; set; }

        public bool StateOpened { get; set; }

        public bool StateLocked { get; set; }

        public bool StateActive { get; set; }
    }
}
