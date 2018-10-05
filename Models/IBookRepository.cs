using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aprel.Models;

namespace Aprel.Models


{
    public interface IBookRepository
    {
        IEnumerable<Item> Napitki { get; }
        IEnumerable<Item> Coffeemachines { get; }
        IEnumerable<Item> Accessories { get; }
    }
}