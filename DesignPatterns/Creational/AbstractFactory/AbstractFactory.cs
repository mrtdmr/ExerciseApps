using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    #region Ürünler
    public abstract class Connection
    {
        public abstract bool Connect();
        public abstract bool Disconnect();
        public abstract string State
        {
            get;
        }
    }
    public abstract class Command
    {
        public abstract void Excute(string query);
    }
    public class DB2Connection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            Console.WriteLine("DB2 bağlantısı açılacak.");
            return true;
        }

        public override bool Disconnect()
        {
            Console.WriteLine("DB2 bağlantısı kapatılacak.");
            return false;
        }
    }
    public class InterBaseConnection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            Console.WriteLine("InterBase bağlantısı açılacak.");
            return true;
        }

        public override bool Disconnect()
        {
            Console.WriteLine("InterBase bağlantısı kapatılacak.");
            return false;
        }
    }
    public class DB2Command : Command
    {
        public override void Excute(string query)
        {
            Console.WriteLine("DB2 sorgusu çalıştırılır.");
        }
    }
    public class InterBaseCommand : Command
    {
        public override void Excute(string query)
        {
            Console.WriteLine("InterBase sorgusu çalıştırılır.");
        }
    }
    #endregion

    #region Factory
    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
    public class DB2Factory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new DB2Command();
        }

        public override Connection CreateConnection()
        {
            return new DB2Connection();
        }
    }
    public class InterBaseFactory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new InterBaseCommand();
        }

        public override Connection CreateConnection()
        {
            return new InterBaseConnection();
        }
    }
    public class Factory
    {
        private DatabaseFactory _databaseFactory;
        private Connection _connection;
        private Command _command;
        public Factory(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = _databaseFactory.CreateConnection();
            _command = _databaseFactory.CreateCommand();
        }
        public void Start()
        {
            _connection.Connect();
            if (_connection.State== "Open")
            {
                _command.Excute("Select...");
            }
        }
    }
    #endregion
}
