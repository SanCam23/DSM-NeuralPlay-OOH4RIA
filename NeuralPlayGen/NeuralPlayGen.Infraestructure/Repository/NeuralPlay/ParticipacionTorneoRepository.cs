
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
 * Clase ParticipacionTorneo:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class ParticipacionTorneoRepository : BasicRepository, IParticipacionTorneoRepository
{
public ParticipacionTorneoRepository() : base ()
{
}


public ParticipacionTorneoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public ParticipacionTorneoEN ReadOIDDefault (int id
                                             )
{
        ParticipacionTorneoEN participacionTorneoEN = null;

        try
        {
                SessionInitializeTransaction ();
                participacionTorneoEN = (ParticipacionTorneoEN)session.Get (typeof(ParticipacionTorneoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return participacionTorneoEN;
}

public System.Collections.Generic.IList<ParticipacionTorneoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ParticipacionTorneoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ParticipacionTorneoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<ParticipacionTorneoEN>();
                        else
                                result = session.CreateCriteria (typeof(ParticipacionTorneoNH)).List<ParticipacionTorneoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ParticipacionTorneoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ParticipacionTorneoEN participacionTorneo)
{
        try
        {
                SessionInitializeTransaction ();
                ParticipacionTorneoNH participacionTorneoNH = (ParticipacionTorneoNH)session.Load (typeof(ParticipacionTorneoNH), participacionTorneo.Id);

                participacionTorneoNH.Estado = participacionTorneo.Estado;


                participacionTorneoNH.FechaAlta = participacionTorneo.FechaAlta;



                session.Update (participacionTorneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ParticipacionTorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ParticipacionTorneoEN participacionTorneo)
{
        ParticipacionTorneoNH participacionTorneoNH = new ParticipacionTorneoNH (participacionTorneo);

        try
        {
                SessionInitializeTransaction ();
                if (participacionTorneo.Torneo != null) {
                        // Argumento OID y no colección.
                        participacionTorneoNH
                        .Torneo = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN), participacionTorneo.Torneo.Id);

                        participacionTorneoNH.Torneo.ParticipacionTorneo
                        .Add (participacionTorneoNH);
                }
                if (participacionTorneo.Equipo != null) {
                        // Argumento OID y no colección.
                        participacionTorneoNH
                        .Equipo = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN), participacionTorneo.Equipo.Id);

                        participacionTorneoNH.Equipo.ParticipacionTorneo
                        .Add (participacionTorneoNH);
                }

                session.Save (participacionTorneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ParticipacionTorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return participacionTorneoNH.Id;
}

public void Modify (ParticipacionTorneoEN participacionTorneo)
{
        try
        {
                SessionInitializeTransaction ();
                ParticipacionTorneoNH participacionTorneoNH = (ParticipacionTorneoNH)session.Load (typeof(ParticipacionTorneoNH), participacionTorneo.Id);

                participacionTorneoNH.Estado = participacionTorneo.Estado;


                participacionTorneoNH.FechaAlta = participacionTorneo.FechaAlta;

                session.Update (participacionTorneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ParticipacionTorneoRepository.", ex);
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
                ParticipacionTorneoNH participacionTorneoNH = (ParticipacionTorneoNH)session.Load (typeof(ParticipacionTorneoNH), id);
                session.Delete (participacionTorneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ParticipacionTorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ParticipacionTorneoEN
public ParticipacionTorneoEN ReadOID (int id
                                      )
{
        ParticipacionTorneoEN participacionTorneoEN = null;

        try
        {
                SessionInitializeTransaction ();
                participacionTorneoEN = (ParticipacionTorneoEN)session.Get (typeof(ParticipacionTorneoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return participacionTorneoEN;
}

public System.Collections.Generic.IList<ParticipacionTorneoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ParticipacionTorneoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ParticipacionTorneoNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<ParticipacionTorneoEN>();
                else
                        result = session.CreateCriteria (typeof(ParticipacionTorneoNH)).List<ParticipacionTorneoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ParticipacionTorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
