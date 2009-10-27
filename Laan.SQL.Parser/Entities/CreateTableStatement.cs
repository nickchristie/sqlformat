using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Laan.SQL.Parser
{
    [ DebuggerDisplay("{Value}") ]
    public class CreateTableStatement : IStatement
    {
        public bool Terminated { get; set; }
        public CreateTableStatement()
        {
            Fields = new FieldDefinitions();
        }

        public string TableName { get; set; }
        public FieldDefinitions Fields { get; set; }

        #region IStatement Members

        public string Value
        {
            get
            {
                return String.Format(
                    "CREATE TABLE {0}\n(\n{1}\n)",
                    TableName,
                    String.Join( ",\n", Fields.Select( fld => "\t" + fld.ToString() ).ToArray() )
                );
            }
        }

        #endregion
    }
}
