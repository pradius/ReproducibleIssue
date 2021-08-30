using ReproducibleIssue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReproducibleIssue.Service
{
    public class RulesService
    {
        public IEnumerable<RulemanModel> GetRules(string Id)
        {
            return _data.Where(x => x.SwciId.Equals(Id));
        }

        private List<RulemanModel> _data = new List<RulemanModel>() {

            new RulemanModel(1, "1", "Affirmed", "Device", "Physical"),
            new RulemanModel(2, "1", "Affirmed", "Device", "Physical"),
            new RulemanModel(3, "2", "Reviewed", "Device", "far"),
            new RulemanModel(4, "2", "Affirmed", "Device", "local"),
            new RulemanModel(5, "1", "Affirmed", "Device", "Physical"),
            new RulemanModel(6, "3", "Affirmed", "Device", "away"),
            new RulemanModel(7, "4", "Affirmed", "Device", "Physical"),
            new RulemanModel(8, "5", "Affirmed", "Device", "logical")

        };
    }
}
