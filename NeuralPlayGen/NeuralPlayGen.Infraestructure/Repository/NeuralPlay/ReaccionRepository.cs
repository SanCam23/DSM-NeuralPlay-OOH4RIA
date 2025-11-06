
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
 * Clase Reaccion:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class ReaccionRepository : BasicRepository, IReaccionRepository
{
public ReaccionRepository() : base ()
{
}


public ReaccionRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public ReaccionEN ReadOIDDefault (int id
                                  )
{
        ReaccionEN reaccionEN = null;

        try
        {
                SessionInitializeTransaction ();
                reaccionEN = (ReaccionEN)session.Get (typeof(ReaccionNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return reaccionEN;
}

public System.Collections.Generic.IList<ReaccionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ReaccionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ReaccionNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<ReaccionEN>();
                        else
                                result = session.CreateCriteria (typeof(ReaccionNH)).List<ReaccionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReaccionRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ReaccionEN reaccion)
{
        try
        {
                SessionInitializeTransaction ();
                ReaccionNH reaccionNH = (ReaccionNH)session.Load (typeof(ReaccionNH), reaccion.Id);

                reaccionNH.Tipo = reaccion.Tipo;


                reaccionNH.FechaCreacion = reaccion.FechaCreacion;





                session.Update (reaccionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReaccionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ReaccionEN reaccion)
{
        ReaccionNH reaccionNH = new ReaccionNH (reaccion);

        try
        {
                SessionInitializeTransaction ();
                if (reaccion.Usuario != null) {
                        // Argumento OID y no colección.
                        reaccionNH
                        .Usuario = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN), reaccion.Usuario.Id);

                        reaccionNH.Usuario.Reaccion
                        .Add (reaccionNH);
                }

                session.Save (reaccionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReaccionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reaccionNH.Id;
}

public void Modify (ReaccionEN reaccion)
{
        try
        {
                SessionInitializeTransaction ();
                ReaccionNH reaccionNH = (ReaccionNH)session.Load (typeof(ReaccionNH), reaccion.Id);

                reaccionNH.Tipo = reaccion.Tipo;


                reaccionNH.FechaCreacion = reaccion.FechaCreacion;

                session.Update (reaccionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReaccionRepository.", ex);
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
                ReaccionNH reaccionNH = (ReaccionNH)session.Load (typeof(ReaccionNH), id);
                session.Delete (reaccionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReaccionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ReaccionEN
public ReaccionEN ReadOID (int id
                           )
{
        ReaccionEN reaccionEN = null;

        try
        {
                SessionInitializeTransaction ();
                reaccionEN = (ReaccionEN)session.Get (typeof(ReaccionNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return reaccionEN;
}

public System.Collections.Generic.IList<ReaccionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ReaccionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ReaccionNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<ReaccionEN>();
                else
                        result = session.CreateCriteria (typeof(ReaccionNH)).List<ReaccionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReaccionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
