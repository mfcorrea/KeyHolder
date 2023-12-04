using System.Data.OleDb;

namespace KeyHolder.Classes
{
    internal class Key: ActiveRecord<Key>
    {
        public int Code { get; set; }
        public string? Description { get; set; }
        public string? Details { get; set; }

        public override int Save()
        {
            if (Code == 0)
            {
                var lista = Find(this);
                if (lista.Count > 0)
                {
                    Code = lista.Max(item => item.Code) + 1;
                }
                else
                {
                    Code = 1;
                }
            }

            //write data in EXCEL sheet (Insert data)
            using (var conn = new OleDbConnection(ConnectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Insert into [Chaves$] (código,nome,observação) VALUES (@codigo,@nome,@observacao);";

                OleDbParameter parametro1 = new OleDbParameter("@codigo", OleDbType.Integer);
                parametro1.Value = Code;
                cmd.Parameters.Add(parametro1);

                OleDbParameter parametro2 = new OleDbParameter("@nome", OleDbType.VarChar);
                parametro2.Value = Description;
                cmd.Parameters.Add(parametro2);

                OleDbParameter parametro3 = new OleDbParameter("@observacao", OleDbType.VarChar);
                parametro3.Value = Details;
                cmd.Parameters.Add(parametro3);

                cmd.ExecuteNonQuery();

                return Code;
            }
        }

        public override List<Key> Find(Key key)
        {
            var chaves = new List<Key>();
            //write data in EXCEL sheet (Insert data)
            using (var conn = new OleDbConnection(ConnectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from [Chaves$]";

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!(reader["código"] is DBNull))
                        {
                            var item = new Key();
                            // Acesso aos dados usando o índice ou nome da coluna
                            item.Code = Convert.ToInt32(reader["código"]);
                            item.Description = reader["nome"].ToString() ?? String.Empty;
                            item.Details = reader["observação"].ToString() ?? String.Empty;

                            chaves.Add(item);
                        }
                    }
                }

            }
            return chaves;
        }

        public override int Delete()
        {
            throw new NotImplementedException();
        }

    }
}