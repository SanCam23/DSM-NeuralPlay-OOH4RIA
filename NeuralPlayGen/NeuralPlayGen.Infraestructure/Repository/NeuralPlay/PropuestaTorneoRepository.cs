
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
 * Clase PropuestaTorneo:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class PropuestaTorneoRepository : BasicRepository, IPropuestaTorneoRepository
{
public PropuestaTorneoRepository() : base ()
{
}


public PropuestaTorneoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public PropuestaTorneoEN ReadOIDDefault (int id
                                         )
{
        PropuestaTorneoEN propuestaTorneoEN = null;

        try
        {
                SessionInitializeTransaction ();
                propuestaTorneoEN = (PropuestaTorneoEN)session.Get (typeof(PropuestaTorneoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return propuestaTorneoEN;
}

public System.Collections.Generic.IList<PropuestaTorneoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PropuestaTorneoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PropuestaTorneoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<PropuestaTorneoEN>();
                        else
                                result = session.CreateCriteria (typeof(PropuestaTorneoNH)).List<PropuestaTorneoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in PropuestaTorneoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PropuestaTorneoEN propuestaTorneo)
{
        try
        {
                SessionInitializeTransaction ();
                PropuestaTorneoNH propuestaTorneoNH = (PropuestaTorneoNH)session.Load (typeof(PropuestaTorneoNH), propuestaTorneo.Id);

                propuestaTorneoNH.FechaPropuesta = propuestaTorneo.FechaPropuesta;


                propuestaTorneoNH.Estado = propuestaTorneo.Estado;







                propuestaTorneoNH.Nombre = propuestaTorneo.Nombre;


                session.Update (propuestaTorneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in PropuestaTorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PropuestaTorneoEN propuestaTorneo)
{
        PropuestaTorneoNH propuestaTorneoNH = new PropuestaTorneoNH (propuestaTorneo);

        try
        {
                SessionInitializeTransaction ();
                if (propuestaTorneo.Torneo != null) {
                        // Argumento OID y no colección.
                        propuestaTorneoNH
                        .Torneo = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN), propuestaTorneo.Torneo.Id);

                        propuestaTorneoNH.Torneo.PropuestaTorneo
                        .Add (propuestaTorneoNH);
                }
                if (propuestaTorneo.Equipo != null) {
                        // Argumento OID y no colección.
                        propuestaTorneoNH
                        .Equipo = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN), propuestaTorneo.Equipo.Id);

                        propuestaTorneoNH.Equipo.PropuestaTorneo
                        .Add (propuestaTorneoNH);
                }
                if (propuestaTorneo.Usuario != null) {
                        // Argumento OID y no colección.
                        propuestaTorneoNH
                        .Usuario = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN), propuestaTorneo.Usuario.Id);

                        propuestaTorneoNH.Usuario.PropuestaTorneo
                        .Add (propuestaTorneoNH);
                }

                session.Save (propuestaTorneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in PropuestaTorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return propuestaTorneoNH.Id;
}

public void Modify (PropuestaTorneoEN propuestaTorneo)
{
        try
        {
                SessionInitializeTransaction ();
                PropuestaTorneoNH propuestaTorneoNH = (PropuestaTorneoNH)session.Load (typeof(PropuestaTorneoNH), propuestaTorneo.Id);

                propuestaTorneoNH.FechaPropuesta = propuestaTorneo.FechaPropuesta;


                propuestaTorneoNH.Estado = propuestaTorneo.Estado;


                propuestaTorneoNH.Nombre = propuestaTorneo.Nombre;

                session.Update (propuestaTorneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in PropuestaTorneoRepository.", ex);
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
                PropuestaTorneoNH propuestaTorneoNH = (PropuestaTorneoNH)session.Load (typeof(PropuestaTorneoNH), id);
                session.Delete (propuestaTorneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in PropuestaTorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: PropuestaTorneoEN
public PropuestaTorneoEN ReadOID (int id
                                  )
{
        PropuestaTorneoEN propuestaTorneoEN = null;

        try
        {
                SessionInitializeTransaction ();
                propuestaTorneoEN = (PropuestaTorneoEN)session.Get (typeof(PropuestaTorneoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return propuestaTorneoEN;
}

public System.Collections.Generic.IList<PropuestaTorneoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PropuestaTorneoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PropuestaTorneoNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<PropuestaTorneoEN>();
                else
                        result = session.CreateCriteria (typeof(PropuestaTorneoNH)).List<PropuestaTorneoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in PropuestaTorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
