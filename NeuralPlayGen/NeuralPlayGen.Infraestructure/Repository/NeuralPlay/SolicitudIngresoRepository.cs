
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
 * Clase SolicitudIngreso:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class SolicitudIngresoRepository : BasicRepository, ISolicitudIngresoRepository
{
public SolicitudIngresoRepository() : base ()
{
}


public SolicitudIngresoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public SolicitudIngresoEN ReadOIDDefault (int id
                                          )
{
        SolicitudIngresoEN solicitudIngresoEN = null;

        try
        {
                SessionInitializeTransaction ();
                solicitudIngresoEN = (SolicitudIngresoEN)session.Get (typeof(SolicitudIngresoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return solicitudIngresoEN;
}

public System.Collections.Generic.IList<SolicitudIngresoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<SolicitudIngresoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(SolicitudIngresoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<SolicitudIngresoEN>();
                        else
                                result = session.CreateCriteria (typeof(SolicitudIngresoNH)).List<SolicitudIngresoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in SolicitudIngresoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (SolicitudIngresoEN solicitudIngreso)
{
        try
        {
                SessionInitializeTransaction ();
                SolicitudIngresoNH solicitudIngresoNH = (SolicitudIngresoNH)session.Load (typeof(SolicitudIngresoNH), solicitudIngreso.Id);

                solicitudIngresoNH.Tipo = solicitudIngreso.Tipo;


                solicitudIngresoNH.Estado = solicitudIngreso.Estado;


                solicitudIngresoNH.FechaSolicitud = solicitudIngreso.FechaSolicitud;


                solicitudIngresoNH.FechaResolucion = solicitudIngreso.FechaResolucion;




                session.Update (solicitudIngresoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in SolicitudIngresoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (SolicitudIngresoEN solicitudIngreso)
{
        SolicitudIngresoNH solicitudIngresoNH = new SolicitudIngresoNH (solicitudIngreso);

        try
        {
                SessionInitializeTransaction ();
                if (solicitudIngreso.Comunidad != null) {
                        // Argumento OID y no colección.
                        solicitudIngresoNH
                        .Comunidad = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN), solicitudIngreso.Comunidad.Id);

                        solicitudIngresoNH.Comunidad.SolicitudIngreso
                        .Add (solicitudIngresoNH);
                }
                if (solicitudIngreso.Usuario != null) {
                        // Argumento OID y no colección.
                        solicitudIngresoNH
                        .Usuario = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN), solicitudIngreso.Usuario.Id);

                        solicitudIngresoNH.Usuario.SolicitudIngreso
                        .Add (solicitudIngresoNH);
                }

                session.Save (solicitudIngresoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in SolicitudIngresoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return solicitudIngresoNH.Id;
}

public void Modify (SolicitudIngresoEN solicitudIngreso)
{
        try
        {
                SessionInitializeTransaction ();
                SolicitudIngresoNH solicitudIngresoNH = (SolicitudIngresoNH)session.Load (typeof(SolicitudIngresoNH), solicitudIngreso.Id);

                solicitudIngresoNH.Tipo = solicitudIngreso.Tipo;


                solicitudIngresoNH.Estado = solicitudIngreso.Estado;


                solicitudIngresoNH.FechaSolicitud = solicitudIngreso.FechaSolicitud;

                session.Update (solicitudIngresoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in SolicitudIngresoRepository.", ex);
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
                SolicitudIngresoNH solicitudIngresoNH = (SolicitudIngresoNH)session.Load (typeof(SolicitudIngresoNH), id);
                session.Delete (solicitudIngresoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in SolicitudIngresoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: SolicitudIngresoEN
public SolicitudIngresoEN ReadOID (int id
                                   )
{
        SolicitudIngresoEN solicitudIngresoEN = null;

        try
        {
                SessionInitializeTransaction ();
                solicitudIngresoEN = (SolicitudIngresoEN)session.Get (typeof(SolicitudIngresoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return solicitudIngresoEN;
}

public System.Collections.Generic.IList<SolicitudIngresoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SolicitudIngresoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(SolicitudIngresoNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<SolicitudIngresoEN>();
                else
                        result = session.CreateCriteria (typeof(SolicitudIngresoNH)).List<SolicitudIngresoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in SolicitudIngresoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
