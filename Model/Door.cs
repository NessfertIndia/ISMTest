namespace ISMTest.Model
{
    public enum DoorStateOpen { Open, Closed }
    public enum DoorStateLocked { Locked, UnLocked }
    public enum DoorStateActive { Active, Alarmed }



    public class Door
    {
        public Guid Identifier { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DoorStateOpen StateOpen { get; set; }
        public DoorStateLocked StateLocked { get; set; }
        public DoorStateActive StateActive { get; set; }
    }
}
