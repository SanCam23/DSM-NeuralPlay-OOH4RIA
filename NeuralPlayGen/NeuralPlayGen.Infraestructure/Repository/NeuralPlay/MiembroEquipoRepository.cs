
using System;
using System.Text;
using NeuralPlayGen.ApplicationCore.CEN.NeuralPlay;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.Exceptions;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;
using NeuralPlayGen.Infraestructure.EN.NeuralPlay;


/*
 * Clase MiembroEquipo:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class MiembroEquipoRepository : BasicRepository, IMiembroEquipoRepository
{
public MiembroEquipoRepository() : base ()
{
}


public MiembroEquipoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public MiembroEquipoEN ReadOIDDefault (int id
                                       )
{
        MiembroEquipoEN miembroEquipoEN = null;

        try
        {
                SessionInitializeTransaction ();
                miembroEquipoEN = (MiembroEquipoEN)session.Get (typeof(MiembroEquipoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return miembroEquipoEN;
}

public System.Collections.Generic.IList<MiembroEquipoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MiembroEquipoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MiembroEquipoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<MiembroEquipoEN>();
                        else
                                result = session.CreateCriteria (typeof(MiembroEquipoNH)).List<MiembroEquipoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MiembroEquipoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MiembroEquipoEN miembroEquipo)
{
        try
        {
                SessionInitializeTransaction ();
                MiembroEquipoNH miembroEquipoNH = (MiembroEquipoNH)session.Load (typeof(MiembroEquipoNH), miembroEquipo.Id);

                miembroEquipoNH.Rol = miembroEquipo.Rol;


                miembroEquipoNH.Estado = miembroEquipo.Estado;


                miembroEquipoNH.FechaAlta = miembroEquipo.FechaAlta;



                session.Update (miembroEquipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MiembroEquipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (MiembroEquipoEN miembroEquipo)
{
        MiembroEquipoNH miembroEquipoNH = new MiembroEquipoNH (miembroEquipo);

        try
        {
                SessionInitializeTransaction ();
                if (miembroEquipo.Equipo != null) {
                        // Argumento OID y no colección.
                        miembroEquipoNH
                        .Equipo = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN), miembroEquipo.Equipo.Id);

                        miembroEquipoNH.Equipo.MiembroEquipo
                        .Add (miembroEquipoNH);
                }
                if (miembroEquipo.Usuario != null) {
                        // Argumento OID y no colección.
                        miembroEquipoNH
                        .Usuario = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN), miembroEquipo.Usuario.Id);

                        miembroEquipoNH.Usuario.MiembroEquipo
                        .Add (miembroEquipoNH);
                }

                session.Save (miembroEquipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MiembroEquipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return miembroEquipoNH.Id;
}

public void Modify (MiembroEquipoEN miembroEquipo)
{
        try
        {
                SessionInitializeTransaction ();
                MiembroEquipoNH miembroEquipoNH = (MiembroEquipoNH)session.Load (typeof(MiembroEquipoNH), miembroEquipo.Id);

                miembroEquipoNH.Rol = miembroEquipo.Rol;


                miembroEquipoNH.Estado = miembroEquipo.Estado;


                miembroEquipoNH.FechaAlta = miembroEquipo.FechaAlta;

                session.Update (miembroEquipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MiembroEquipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                MiembroEquipoNH miembroEquipoNH = (MiembroEquipoNH)session.Load (typeof(MiembroEquipoNH), id);
                session.Delete (miembroEquipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MiembroEquipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: MiembroEquipoEN
public MiembroEquipoEN ReadOID (int id
                                )
{
        MiembroEquipoEN miembroEquipoEN = null;

        try
        {
                SessionInitializeTransaction ();
                miembroEquipoEN = (MiembroEquipoEN)session.Get (typeof(MiembroEquipoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return miembroEquipoEN;
}

public System.Collections.Generic.IList<MiembroEquipoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MiembroEquipoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MiembroEquipoNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<MiembroEquipoEN>();
                else
                        result = session.CreateCriteria (typeof(MiembroEquipoNH)).List<MiembroEquipoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MiembroEquipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
