using System.Collections.Generic;

//c Add IRepository.cs in Models folder.

namespace PartyInvites.Models {
    public interface IRepository {
        IEnumerable<GuestResponse> Responses {get; }
        void AddResponse(GuestResponse response);
    }
}