﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectedPosition.cs" company="Joerg Battermann">
//   Copyright © Joerg Battermann 2014
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace GeoJSON.Net.Geometry
{
    using System;
    using System.Globalization;

    /// <summary>
    /// Defines the Projected Position type a.k.a. Projected Coordinate Reference System.
    /// </summary>
    [Obsolete("This is no longer in the GeoJSON RFC")]
    public class ProjectedPosition : Position
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectedPosition"/> class.
        /// </summary>
        /// <param name="easting">The easting.</param>
        /// <param name="northing">The northing.</param>
        /// <param name="altitude">The altitude in m(eter).</param>
        public ProjectedPosition(double easting, double northing, double? altitude)
            : this()
        {
            throw new NotImplementedException("Someone needs to do this...");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectedPosition"/> class.
        /// </summary>
        /// <param name="easting">The easting, e.g. '38.889722'.</param>
        /// <param name="northing">The northing, e.g. '-77.008889'.</param>
        /// <param name="altitude">The altitude in m(eter).</param>
        public ProjectedPosition(string easting, string northing, string altitude)
            : this()
        {
            throw new NotImplementedException("Someone needs to do this...");
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="ProjectedPosition"/> class from being created.
        /// </summary>
        private ProjectedPosition()
        {
            throw new NotImplementedException("Someone needs to do this...");
        }

        /// <summary>
        /// Gets the easting.
        /// </summary>
        /// <value>The easting.</value>
        public double Easting
        {
            get
            {
                throw new NotImplementedException("Someone needs to do this...");
            }
        }

        /// <summary>
        /// Gets the northing.
        /// </summary>
        /// <value>The northing.</value>
        public double Northing
        {
            get
            {
                throw new NotImplementedException("Someone needs to do this...");
            }
        }

        /// <summary>
        /// Gets the altitude.
        /// </summary>
        public double? Altitude
        {
            get
            {
                throw new NotImplementedException("Someone needs to do this...");
            }
        }

        /// <summary>
        /// Returns a <see cref="string"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return Altitude == null 
                ? string.Format(CultureInfo.InvariantCulture, "Easting: {0}, Northing: {1}", Easting, Northing) 
                : string.Format(CultureInfo.InvariantCulture, "Easting: {0}, Northing: {1}, Altitude: {2}", Easting, Northing, Altitude);
        }
    }
}
