
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
 * Clase VotoTorneo:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class VotoTorneoRepository : BasicRepository, IVotoTorneoRepository
{
public VotoTorneoRepository() : base ()
{
}


public VotoTorneoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public VotoTorneoEN ReadOIDDefault (int id
                                    )
{
        VotoTorneoEN votoTorneoEN = null;

        try
        {
                SessionInitializeTransaction ();
                votoTorneoEN = (VotoTorneoEN)session.Get (typeof(VotoTorneoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return votoTorneoEN;
}

public System.Collections.Generic.IList<VotoTorneoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<VotoTorneoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(VotoTorneoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<VotoTorneoEN>();
                        else
                                result = session.CreateCriteria (typeof(VotoTorneoNH)).List<VotoTorneoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in VotoTorneoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (VotoTorneoEN votoTorneo)
{
        try
        {
                SessionInitializeTransaction ();
                VotoTorneoNH votoTorneoNH = (VotoTorneoNH)session.Load (typeof(VotoTorneoNH), votoTorneo.Id);

                votoTorneoNH.Valor = votoTorneo.Valor;


                votoTorneoNH.FechaVoto = votoTorneo.FechaVoto;



                session.Update (votoTorneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in VotoTorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (VotoTorneoEN votoTorneo)
{
        VotoTorneoNH votoTorneoNH = new VotoTorneoNH (votoTorneo);

        try
        {
                SessionInitializeTransaction ();
                if (votoTorneo.PropuestaTorneo != null) {
                        // Argumento OID y no colección.
                        votoTorneoNH
                        .PropuestaTorneo = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN), votoTorneo.PropuestaTorneo.Id);

                        votoTorneoNH.PropuestaTorneo.VotoTorneo
                        .Add (votoTorneoNH);
                }
                if (votoTorneo.Usuario != null) {
                        // Argumento OID y no colección.
                        votoTorneoNH
                        .Usuario = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN), votoTorneo.Usuario.Id);

                        votoTorneoNH.Usuario.VotoTorneo
                        .Add (votoTorneoNH);
                }

                session.Save (votoTorneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in VotoTorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return votoTorneoNH.Id;
}

public void Modify (VotoTorneoEN votoTorneo)
{
        try
        {
                SessionInitializeTransaction ();
                VotoTorneoNH votoTorneoNH = (VotoTorneoNH)session.Load (typeof(VotoTorneoNH), votoTorneo.Id);

                votoTorneoNH.Valor = votoTorneo.Valor;


                votoTorneoNH.FechaVoto = votoTorneo.FechaVoto;

                session.Update (votoTorneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in VotoTorneoRepository.", ex);
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
                VotoTorneoNH votoTorneoNH = (VotoTorneoNH)session.Load (typeof(VotoTorneoNH), id);
                session.Delete (votoTorneoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in VotoTorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: VotoTorneoEN
public VotoTorneoEN ReadOID (int id
                             )
{
        VotoTorneoEN votoTorneoEN = null;

        try
        {
                SessionInitializeTransaction ();
                votoTorneoEN = (VotoTorneoEN)session.Get (typeof(VotoTorneoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return votoTorneoEN;
}

public System.Collections.Generic.IList<VotoTorneoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<VotoTorneoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(VotoTorneoNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<VotoTorneoEN>();
                else
                        result = session.CreateCriteria (typeof(VotoTorneoNH)).List<VotoTorneoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in VotoTorneoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
