using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using System.Linq;
using VisagieMotors.Data;
using VisagieMotors.Domain;


namespace VisagieMotors.Repository
{
    public class MotorRepository
    {
        private readonly IDbConnection _connection;

        public MotorRepository()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["mainsql"].ConnectionString);
        }

        public List<Motor> GetAll()
        {
            var sql = @"SELECT * FROM motors";

            var motors = _connection.Query<motor_data>(sql);

            return motors.Select(motor => motor.toDomain()).ToList();
        }
    }
}
