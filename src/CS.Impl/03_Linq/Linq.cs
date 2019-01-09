using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CS.Impl._03_Linq
{
    public class Linq
    {
        public IEnumerable<string> FindStringsWhichStartsAndEndsWithSpecificCharacter(string startCharacter, string endCharacter, IEnumerable<string> strings)
        {
            return strings.Where(oneString => oneString.StartsWith(startCharacter) && oneString.EndsWith(endCharacter));
        }

        public IEnumerable<int> GetGreaterNumbers(int limit, IEnumerable<int> numbers)
        {
            return numbers.Where(number => number > limit);
        }

        public IEnumerable<int> GetTopNRecords(int limit, IEnumerable<int> numbers)
        {
            return numbers.OrderBy(n => n).TakeLast(limit);
        }

        public IDictionary<string, int> GetFileCountByExtension(IEnumerable<string> files)
        {
            var groupedFiles = files.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                .GroupBy(group => group,
                    (extension, extensionCount) => new {Extension = extension, Count = extensionCount.Count()});

            return groupedFiles.ToDictionary(d => d.Extension, d => d.Count);
        }

        public IEnumerable<Tuple<string, string, int, double>> GetFinalReceipe(List<Item> items, List<Client> clients, List<Purchase> purchases)
        {
            return from purchase in purchases
                join item in items on purchase.ItemId equals item.Id
                join client in clients on purchase.ClientId equals client.Id
                select new Tuple<string, string, int, double>(client.Name, item.Label, purchase.Quantity, item.Price);
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public double Price { get; set; }
    }

    public class Purchase
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int ClientId { get; set; }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
