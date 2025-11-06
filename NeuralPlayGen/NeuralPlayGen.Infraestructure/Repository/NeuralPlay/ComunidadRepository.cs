
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
 * Clase Comunidad:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class ComunidadRepository : BasicRepository, IComunidadRepository
{
public ComunidadRepository() : base ()
{
}


public ComunidadRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public ComunidadEN ReadOIDDefault (int id
                                   )
{
        ComunidadEN comunidadEN = null;

        try
        {
                SessionInitializeTransaction ();
                comunidadEN = (ComunidadEN)session.Get (typeof(ComunidadNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return comunidadEN;
}

public System.Collections.Generic.IList<ComunidadEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ComunidadEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ComunidadNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<ComunidadEN>();
                        else
                                result = session.CreateCriteria (typeof(ComunidadNH)).List<ComunidadEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ComunidadRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ComunidadEN comunidad)
{
        try
        {
                SessionInitializeTransaction ();
                ComunidadNH comunidadNH = (ComunidadNH)session.Load (typeof(ComunidadNH), comunidad.Id);

                comunidadNH.Nombre = comunidad.Nombre;


                comunidadNH.Descripcion = comunidad.Descripcion;


                comunidadNH.FechaCreacion = comunidad.FechaCreacion;








                session.Update (comunidadNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ComunidadRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ComunidadEN comunidad)
{
        ComunidadNH comunidadNH = new ComunidadNH (comunidad);

        try
        {
                SessionInitializeTransaction ();
                if (comunidad.PropuestaTorneo != null) {
                        // Argumento OID y no colección.
                        comunidadNH
                        .PropuestaTorneo = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN), comunidad.PropuestaTorneo.Id);

                        comunidadNH.PropuestaTorneo.Comunidad
                        .Add (comunidadNH);
                }

                session.Save (comunidadNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ComunidadRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return comunidadNH.Id;
}

public void Modify (ComunidadEN comunidad)
{
        try
        {
                SessionInitializeTransaction ();
                ComunidadNH comunidadNH = (ComunidadNH)session.Load (typeof(ComunidadNH), comunidad.Id);

                comunidadNH.Nombre = comunidad.Nombre;


                comunidadNH.Descripcion = comunidad.Descripcion;


                comunidadNH.FechaCreacion = comunidad.FechaCreacion;

                session.Update (comunidadNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ComunidadRepository.", ex);
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
                ComunidadNH comunidadNH = (ComunidadNH)session.Load (typeof(ComunidadNH), id);
                session.Delete (comunidadNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ComunidadRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ComunidadEN
public ComunidadEN ReadOID (int id
                            )
{
        ComunidadEN comunidadEN = null;

        try
        {
                SessionInitializeTransaction ();
                comunidadEN = (ComunidadEN)session.Get (typeof(ComunidadNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return comunidadEN;
}

public System.Collections.Generic.IList<ComunidadEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ComunidadEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ComunidadNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<ComunidadEN>();
                else
                        result = session.CreateCriteria (typeof(ComunidadNH)).List<ComunidadEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ComunidadRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
