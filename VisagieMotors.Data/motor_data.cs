using VisagieMotors.Domain;

namespace VisagieMotors.Data
{
    public class motor_data
    {
        public int id { get; set; }
        public string motor_manufacturer { get; set; }
        public string motor_type { get; set; }
        public string motor_model { get; set; }
        public string motor_price;

        public Motor toDomain()
        {
            return new Motor
            {
                Id = id,
                MotorManufacturer = motor_manufacturer,
                TypeOfMotor = motor_type,
                MotorModel = motor_model,
                Price = motor_price
            };
        }
    }
}