namespace FabrikamFiber.Web
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Globalization;
    using FabrikamFiber.DAL.Data;
    using FabrikamFiber.DAL.Models;

    public class FabrikamFiberDatabaseInitializer : MigrateDatabaseToLatestVersion<FabrikamFiberWebContext, FabrikamFiber.DAL.Migrations.Configuration>
    {

    }
}