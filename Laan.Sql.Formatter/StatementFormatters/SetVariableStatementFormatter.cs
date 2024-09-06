using Laan.Sql.Parser.Entities;
using System.Text;

namespace Laan.Sql.Formatter
{
    public class SetVariableStatementFormatter : StatementFormatter<SetVariableStatement>, IStatementFormatter
    {
        public SetVariableStatementFormatter(IIndentable indentable, StringBuilder sql, SetVariableStatement statement)
            : base(indentable, sql, statement)
        {
        }

        public void Execute()
        {
            var formatter = new VariableAssignmentFormatter(_statement.Variable, _statement.Assignment, this, _sql);
            formatter.Execute();
        }
    }
}
