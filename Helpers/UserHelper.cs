using DesafioMutant.API.Models;
using System.Collections.Generic;

namespace DesafioMutant.API.Helpers
{
    public class UserHelper
    {
        public static List<UserDTO> FilterUsersInSuite(List<UserDTO> users)
        {
            List<UserDTO> result = new List<UserDTO>();

            foreach (var user in users)
            {
                if (user.address.suite.ToLower().Contains("suite"))
                {
                    result.Add(user);
                }
            }

            return result;
        }
    }
}
