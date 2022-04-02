// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Building.cs" company="">
//   
// </copyright>
// <summary>
//   The building.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Buildings
{
    #region

    using System.Text;

    #endregion

    /// <summary>
    /// The building.
    /// </summary>
    internal class Building
    {
        /// <summary>
        /// The _id.
        /// </summary>
        private static int _id = 1;

        /// <summary>
        /// The _apartments.
        /// </summary>
        private int _apartments;

        /// <summary>
        /// The _height.
        /// </summary>
        private double _height;

        /// <summary>
        /// The _number.
        /// </summary>
        private readonly int _number;

        /// <summary>
        /// The _porches.
        /// </summary>
        private int _porches;

        /// <summary>
        /// The _storeys.
        /// </summary>
        private int _storeys;

        /// <summary>
        /// Initializes a new instance of the <see cref="Building"/> class.
        /// </summary>
        public Building()
        {
            this._number = GetNextBuildingId();
        }

        /// <summary>
        /// The apartments.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int Apartments()
        {
            return this._apartments;
        }

        /// <summary>
        /// The apartments per entrance.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int ApartmentsPerEntrance()
        {
            return this._apartments / this._porches;
        }

        /// <summary>
        /// The apartments per floor.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int ApartmentsPerFloor()
        {
            return this._apartments / this.ApartmentsPerEntrance();
        }

        /// <summary>
        /// The get number.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int GetNumber()
        {
            return this._number;
        }

        /// <summary>
        /// The height.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public double Height()
        {
            return this._height;
        }

        /// <summary>
        /// The porches.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int Porches()
        {
            return this._porches;
        }

        /// <summary>
        /// The set apartments.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public void SetApartments(int value)
        {
            this._apartments = value;
        }

        /// <summary>
        /// The set height.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public void SetHeight(double value)
        {
            this._height = value;
        }

        /// <summary>
        /// The set porches.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public void SetPorches(int value)
        {
            this._porches = value;
        }

        /// <summary>
        /// The set storeys.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public void SetStoreys(int value)
        {
            this._storeys = value;
        }

        /// <summary>
        /// The storey height calculations.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public double StoreyHeightCalculations()
        {
            return this._height / this._storeys;
        }

        /// <summary>
        /// The storeys.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int Storeys()
        {
            return this._storeys;
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Number: \t{this._number}");
            sb.AppendLine($"Height: \t{this._height:F2}");
            sb.AppendLine($"Storeys:\t{this._storeys}");
            sb.AppendLine($"Apartments:\t{this._apartments}");
            sb.AppendLine($"Porches:\t{this._porches}");

            return sb.ToString();
        }

        /// <summary>
        /// The get next building id.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        private static int GetNextBuildingId()
        {
            return _id++;
        }
    }
}