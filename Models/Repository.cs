namespace PartyInvites.Models
{
    public class Repository
    {
        private static List<GuestResponse> _response = new();
        public static IEnumerable<GuestResponse> Responses => Responses;
        public static void AddResponse(GuestResponse response)
        {
            Console.WriteLine(response.ToString());
            _response.Add(response);
        }
    }
}
