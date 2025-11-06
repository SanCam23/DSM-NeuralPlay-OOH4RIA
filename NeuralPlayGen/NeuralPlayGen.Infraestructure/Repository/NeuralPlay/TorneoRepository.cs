
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
 * Clase Torneo:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class TorneoRepository : BasicRepository, ITorneoRepository
{
public TorneoRepository() : base ()
{
}


public TorneoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public TorneoEN ReadOIDDefault (int id
                                )
{
        TorneoEN torneoEN = null;

        try
        {
                SessionInitializeTransaction ();
                torneoEN = (TorneoEN)session.Get (typeof(TorneoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return torneoEN;
}

public System.Collections.Generic.IList<TorneoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<TorneoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(TorneoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<TorneoEN>();
                        else
                                result = session.CreateCriteria (typeof(TorneoNH)).List<TorneoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in TorneoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (TorneoEN torneo)
{
        try
        {
                SessionInitializeTransaction ();
                TorneoNH torneoNH = (TorneoNH)session.Load (typeof(TorneoNH), torneo.Id);

                torneoNH.Nombre = torneo.Nombre;


                torneoNH.FechaInicio = torneo.FechaInicio;


                torneoNH.Reglas = torneo.Reglas;


                torneoNH.Estado = torneo.Estado;




                session.Update (torneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in TorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (TorneoEN torneo)
{
        TorneoNH torneoNH = new TorneoNH (torneo);

        try
        {
                SessionInitializeTransaction ();
                if (torneo.Comunidad != null) {
                        // Argumento OID y no colección.
                        torneoNH
                        .Comunidad = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN), torneo.Comunidad.Id);

                        torneoNH.Comunidad.Torneo
                        .Add (torneoNH);
                }

                session.Save (torneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in TorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return torneoNH.Id;
}

public void Modify (TorneoEN torneo)
{
        try
        {
                SessionInitializeTransaction ();
                TorneoNH torneoNH = (TorneoNH)session.Load (typeof(TorneoNH), torneo.Id);

                torneoNH.Nombre = torneo.Nombre;


                torneoNH.FechaInicio = torneo.FechaInicio;


                torneoNH.Reglas = torneo.Reglas;


                torneoNH.Estado = torneo.Estado;

                session.Update (torneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in TorneoRepository.", ex);
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
                TorneoNH torneoNH = (TorneoNH)session.Load (typeof(TorneoNH), id);
                session.Delete (torneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in TorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: TorneoEN
public TorneoEN ReadOID (int id
                         )
{
        TorneoEN torneoEN = null;

        try
        {
                SessionInitializeTransaction ();
                torneoEN = (TorneoEN)session.Get (typeof(TorneoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return torneoEN;
}

public System.Collections.Generic.IList<TorneoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TorneoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(TorneoNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<TorneoEN>();
                else
                        result = session.CreateCriteria (typeof(TorneoNH)).List<TorneoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in TorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN> DameTorneosPorEquipo (int ? t_idEquipo)
{
        System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM TorneoNH self where select torn FROM TorneoNH as torn inner join torn.ParticipacionTorneo as participacion where participacion.Equipo.id = :t_idEquipo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("TorneoNHdameTorneosPorEquipoHQL");
                query.SetParameter ("t_idEquipo", t_idEquipo);

                result = query.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in TorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
