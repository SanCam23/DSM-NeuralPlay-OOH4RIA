
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
 * Clase Sesion:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class SesionRepository : BasicRepository, ISesionRepository
{
public SesionRepository() : base ()
{
}


public SesionRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public SesionEN ReadOIDDefault (int id
                                )
{
        SesionEN sesionEN = null;

        try
        {
                SessionInitializeTransaction ();
                sesionEN = (SesionEN)session.Get (typeof(SesionNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return sesionEN;
}

public System.Collections.Generic.IList<SesionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<SesionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(SesionNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<SesionEN>();
                        else
                                result = session.CreateCriteria (typeof(SesionNH)).List<SesionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in SesionRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (SesionEN sesion)
{
        try
        {
                SessionInitializeTransaction ();
                SesionNH sesionNH = (SesionNH)session.Load (typeof(SesionNH), sesion.Id);

                sesionNH.FechaInicio = sesion.FechaInicio;


                sesionNH.FechaFin = sesion.FechaFin;


                sesionNH.Token = sesion.Token;


                session.Update (sesionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in SesionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (SesionEN sesion)
{
        SesionNH sesionNH = new SesionNH (sesion);

        try
        {
                SessionInitializeTransaction ();
                if (sesion.Usuario != null) {
                        // Argumento OID y no colección.
                        sesionNH
                        .Usuario = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN), sesion.Usuario.Id);

                        sesionNH.Usuario.Sesion
                        .Add (sesionNH);
                }

                session.Save (sesionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in SesionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return sesionNH.Id;
}

public void Modify (SesionEN sesion)
{
        try
        {
                SessionInitializeTransaction ();
                SesionNH sesionNH = (SesionNH)session.Load (typeof(SesionNH), sesion.Id);

                sesionNH.FechaInicio = sesion.FechaInicio;


                sesionNH.FechaFin = sesion.FechaFin;


                sesionNH.Token = sesion.Token;

                session.Update (sesionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in SesionRepository.", ex);
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
                SesionNH sesionNH = (SesionNH)session.Load (typeof(SesionNH), id);
                session.Delete (sesionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in SesionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: SesionEN
public SesionEN ReadOID (int id
                         )
{
        SesionEN sesionEN = null;

        try
        {
                SessionInitializeTransaction ();
                sesionEN = (SesionEN)session.Get (typeof(SesionNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return sesionEN;
}

public System.Collections.Generic.IList<SesionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SesionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(SesionNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<SesionEN>();
                else
                        result = session.CreateCriteria (typeof(SesionNH)).List<SesionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in SesionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
