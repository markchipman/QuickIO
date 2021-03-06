﻿
// <copyright company="Benjamin Abt ( http://www.benjamin-abt.com - http://quickIO.NET )">
//      Copyright (c) 2016 Benjamin Abt Rights Reserved - DO NOT REMOVE OR EDIT COPYRIGHT
// </copyright>
// <author>Benjamin Abt</author>


namespace SchwabenCode.QuickIO
{
    public partial class QuickIOFile
    {

        #region Root

        /// <summary>
        /// Returns the root information
        /// </summary>
        /// <param name="path">The path of a file or directory. </param>
        /// <returns>A QuickIOPathInfo that represents the root or null if <paramref name="path"/> is root.</returns>
        /// <remarks>http://msdn.microsoft.com/en-us/library/system.io.directory.getdirectoryroot(v=vs.110).aspx</remarks>
        public static QuickIOPathInfo GetDirectoryRoot( string path )
        {
            return GetDirectoryRoot( new QuickIOPathInfo ( path ) );
        }

        /// <summary>
        /// Returns the root information
        /// </summary>
        /// <param name="info">A file or directory. </param>
        /// <returns>A QuickIOPathInfo that represents the root or null if <paramref name="info"/> is root.</returns>
        /// <remarks>http://msdn.microsoft.com/en-us/library/system.io.directory.getdirectoryroot(v=vs.110).aspx</remarks>
        public static QuickIOPathInfo GetDirectoryRoot( QuickIOPathInfo info )
        {
            return new QuickIOPathInfo(info.Root);
        }

		/// <summary>
        /// Returns the root information
        /// </summary>
        /// <param name="info">A file or directory. </param>
        /// <returns>A QuickIOPathInfo that represents the root or null if <paramref name="info"/> is root.</returns>
        /// <remarks>http://msdn.microsoft.com/en-us/library/system.io.directory.getdirectoryroot(v=vs.110).aspx</remarks>
        public static QuickIOPathInfo GetDirectoryRoot( QuickIOFileInfo info )
        {
            return new QuickIOPathInfo(info.Root);
        }

        #endregion
    }
}
