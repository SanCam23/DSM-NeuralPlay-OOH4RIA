
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
 * Clase PerfilJuego:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class PerfilJuegoRepository : BasicRepository, IPerfilJuegoRepository
{
public PerfilJuegoRepository() : base ()
{
}


public PerfilJuegoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public PerfilJuegoEN ReadOIDDefault (int id
                                     )
{
        PerfilJuegoEN perfilJuegoEN = null;

        try
        {
                SessionInitializeTransaction ();
                perfilJuegoEN = (PerfilJuegoEN)session.Get (typeof(PerfilJuegoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return perfilJuegoEN;
}

public System.Collections.Generic.IList<PerfilJuegoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PerfilJuegoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PerfilJuegoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<PerfilJuegoEN>();
                        else
                                result = session.CreateCriteria (typeof(PerfilJuegoNH)).List<PerfilJuegoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in PerfilJuegoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PerfilJuegoEN perfilJuego)
{
        try
        {
                SessionInitializeTransaction ();
                PerfilJuegoNH perfilJuegoNH = (PerfilJuegoNH)session.Load (typeof(PerfilJuegoNH), perfilJuego.Id);

                perfilJuegoNH.FechaAccion = perfilJuego.FechaAccion;



                session.Update (perfilJuegoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in PerfilJuegoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PerfilJuegoEN perfilJuego)
{
        PerfilJuegoNH perfilJuegoNH = new PerfilJuegoNH (perfilJuego);

        try
        {
                SessionInitializeTransaction ();
                if (perfilJuego.Perfil != null) {
                        // Argumento OID y no colección.
                        perfilJuegoNH
                        .Perfil = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN), perfilJuego.Perfil.Id);

                        perfilJuegoNH.Perfil.PerfilJuego
                        .Add (perfilJuegoNH);
                }
                if (perfilJuego.Juego != null) {
                        // Argumento OID y no colección.
                        perfilJuegoNH
                        .Juego = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN), perfilJuego.Juego.Id);

                        perfilJuegoNH.Juego.PerfilJuego
                        .Add (perfilJuegoNH);
                }

                session.Save (perfilJuegoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in PerfilJuegoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return perfilJuegoNH.Id;
}

public void Modify (PerfilJuegoEN perfilJuego)
{
        try
        {
                SessionInitializeTransaction ();
                PerfilJuegoNH perfilJuegoNH = (PerfilJuegoNH)session.Load (typeof(PerfilJuegoNH), perfilJuego.Id);

                perfilJuegoNH.FechaAccion = perfilJuego.FechaAccion;

                session.Update (perfilJuegoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in PerfilJuegoRepository.", ex);
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
                PerfilJuegoNH perfilJuegoNH = (PerfilJuegoNH)session.Load (typeof(PerfilJuegoNH), id);
                session.Delete (perfilJuegoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in PerfilJuegoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: PerfilJuegoEN
public PerfilJuegoEN ReadOID (int id
                              )
{
        PerfilJuegoEN perfilJuegoEN = null;

        try
        {
                SessionInitializeTransaction ();
                perfilJuegoEN = (PerfilJuegoEN)session.Get (typeof(PerfilJuegoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return perfilJuegoEN;
}

public System.Collections.Generic.IList<PerfilJuegoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PerfilJuegoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PerfilJuegoNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<PerfilJuegoEN>();
                else
                        result = session.CreateCriteria (typeof(PerfilJuegoNH)).List<PerfilJuegoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in PerfilJuegoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
