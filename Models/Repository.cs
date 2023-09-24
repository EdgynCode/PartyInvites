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
        public static IEnumerable<GuestResponse> GetResponses()
        {
            return _response;
        }

    }
}
