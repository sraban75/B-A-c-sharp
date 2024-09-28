namespace B2A_C_Sharp
{
    internal class Monitor
    {
        private string _name;


        public long Id { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null && value.Length > 1 && value.Length <= 30)
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("Msg..................");
                }
            }
        }


    }
}
