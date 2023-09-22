namespace PartyInvites.Models
{
    public class Repository
    {
        private static List<GuestResponse> _response = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Responses => Responses;
        public static void AddResponse(GuestResponse response)
        {
            Console.WriteLine(response);
            _response.Add(response);
        }
    }
}
