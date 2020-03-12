using System;

namespace Organzier.Models
{
    public class Songs
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}