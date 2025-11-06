
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
 * Clase Juego:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class JuegoRepository : BasicRepository, IJuegoRepository
{
public JuegoRepository() : base ()
{
}


public JuegoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public JuegoEN ReadOIDDefault (int id
                               )
{
        JuegoEN juegoEN = null;

        try
        {
                SessionInitializeTransaction ();
                juegoEN = (JuegoEN)session.Get (typeof(JuegoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return juegoEN;
}

public System.Collections.Generic.IList<JuegoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<JuegoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(JuegoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<JuegoEN>();
                        else
                                result = session.CreateCriteria (typeof(JuegoNH)).List<JuegoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in JuegoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (JuegoEN juego)
{
        try
        {
                SessionInitializeTransaction ();
                JuegoNH juegoNH = (JuegoNH)session.Load (typeof(JuegoNH), juego.Id);

                juegoNH.Nombre = juego.Nombre;


                juegoNH.Genero = juego.Genero;




                session.Update (juegoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in JuegoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (JuegoEN juego)
{
        JuegoNH juegoNH = new JuegoNH (juego);

        try
        {
                SessionInitializeTransaction ();

                session.Save (juegoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in JuegoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return juegoNH.Id;
}

public void Modify (JuegoEN juego)
{
        try
        {
                SessionInitializeTransaction ();
                JuegoNH juegoNH = (JuegoNH)session.Load (typeof(JuegoNH), juego.Id);

                juegoNH.Nombre = juego.Nombre;


                juegoNH.Genero = juego.Genero;

                session.Update (juegoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in JuegoRepository.", ex);
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
                JuegoNH juegoNH = (JuegoNH)session.Load (typeof(JuegoNH), id);
                session.Delete (juegoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in JuegoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: JuegoEN
public JuegoEN ReadOID (int id
                        )
{
        JuegoEN juegoEN = null;

        try
        {
                SessionInitializeTransaction ();
                juegoEN = (JuegoEN)session.Get (typeof(JuegoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return juegoEN;
}

public System.Collections.Generic.IList<JuegoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<JuegoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(JuegoNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<JuegoEN>();
                else
                        result = session.CreateCriteria (typeof(JuegoNH)).List<JuegoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in JuegoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
