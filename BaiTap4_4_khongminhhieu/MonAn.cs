namespace BaiTap4_4_FastFood
{
    public class MonAn
    {
        public string Ten { get; set; }
        public int Gia { get; set; }

        public override string ToString()
        {
            return Ten + " - " + Gia + "đ";
        }
    }
}
