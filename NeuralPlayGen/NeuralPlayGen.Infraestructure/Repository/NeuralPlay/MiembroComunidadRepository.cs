
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
 * Clase MiembroComunidad:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class MiembroComunidadRepository : BasicRepository, IMiembroComunidadRepository
{
public MiembroComunidadRepository() : base ()
{
}


public MiembroComunidadRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public MiembroComunidadEN ReadOIDDefault (int id
                                          )
{
        MiembroComunidadEN miembroComunidadEN = null;

        try
        {
                SessionInitializeTransaction ();
                miembroComunidadEN = (MiembroComunidadEN)session.Get (typeof(MiembroComunidadNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return miembroComunidadEN;
}

public System.Collections.Generic.IList<MiembroComunidadEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MiembroComunidadEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MiembroComunidadNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<MiembroComunidadEN>();
                        else
                                result = session.CreateCriteria (typeof(MiembroComunidadNH)).List<MiembroComunidadEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MiembroComunidadRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MiembroComunidadEN miembroComunidad)
{
        try
        {
                SessionInitializeTransaction ();
                MiembroComunidadNH miembroComunidadNH = (MiembroComunidadNH)session.Load (typeof(MiembroComunidadNH), miembroComunidad.Id);

                miembroComunidadNH.Rol = miembroComunidad.Rol;


                miembroComunidadNH.Estado = miembroComunidad.Estado;


                miembroComunidadNH.FechaAlta = miembroComunidad.FechaAlta;



                session.Update (miembroComunidadNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MiembroComunidadRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (MiembroComunidadEN miembroComunidad)
{
        MiembroComunidadNH miembroComunidadNH = new MiembroComunidadNH (miembroComunidad);

        try
        {
                SessionInitializeTransaction ();
                if (miembroComunidad.Comunidad != null) {
                        // Argumento OID y no colección.
                        miembroComunidadNH
                        .Comunidad = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN), miembroComunidad.Comunidad.Id);

                        miembroComunidadNH.Comunidad.MiembroComunidad
                        .Add (miembroComunidadNH);
                }
                if (miembroComunidad.Usuario != null) {
                        // Argumento OID y no colección.
                        miembroComunidadNH
                        .Usuario = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN), miembroComunidad.Usuario.Id);

                        miembroComunidadNH.Usuario.MiembroComunidad
                        .Add (miembroComunidadNH);
                }

                session.Save (miembroComunidadNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MiembroComunidadRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return miembroComunidadNH.Id;
}

public void Modify (MiembroComunidadEN miembroComunidad)
{
        try
        {
                SessionInitializeTransaction ();
                MiembroComunidadNH miembroComunidadNH = (MiembroComunidadNH)session.Load (typeof(MiembroComunidadNH), miembroComunidad.Id);

                miembroComunidadNH.Rol = miembroComunidad.Rol;


                miembroComunidadNH.Estado = miembroComunidad.Estado;


                miembroComunidadNH.FechaAlta = miembroComunidad.FechaAlta;

                session.Update (miembroComunidadNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MiembroComunidadRepository.", ex);
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
                MiembroComunidadNH miembroComunidadNH = (MiembroComunidadNH)session.Load (typeof(MiembroComunidadNH), id);
                session.Delete (miembroComunidadNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MiembroComunidadRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: MiembroComunidadEN
public MiembroComunidadEN ReadOID (int id
                                   )
{
        MiembroComunidadEN miembroComunidadEN = null;

        try
        {
                SessionInitializeTransaction ();
                miembroComunidadEN = (MiembroComunidadEN)session.Get (typeof(MiembroComunidadNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return miembroComunidadEN;
}

public System.Collections.Generic.IList<MiembroComunidadEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MiembroComunidadEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MiembroComunidadNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<MiembroComunidadEN>();
                else
                        result = session.CreateCriteria (typeof(MiembroComunidadNH)).List<MiembroComunidadEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MiembroComunidadRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
