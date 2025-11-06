
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
 * Clase Invitacion:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class InvitacionRepository : BasicRepository, IInvitacionRepository
{
public InvitacionRepository() : base ()
{
}


public InvitacionRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public InvitacionEN ReadOIDDefault (int id
                                    )
{
        InvitacionEN invitacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                invitacionEN = (InvitacionEN)session.Get (typeof(InvitacionNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return invitacionEN;
}

public System.Collections.Generic.IList<InvitacionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<InvitacionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(InvitacionNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<InvitacionEN>();
                        else
                                result = session.CreateCriteria (typeof(InvitacionNH)).List<InvitacionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in InvitacionRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (InvitacionEN invitacion)
{
        try
        {
                SessionInitializeTransaction ();
                InvitacionNH invitacionNH = (InvitacionNH)session.Load (typeof(InvitacionNH), invitacion.Id);

                invitacionNH.Tipo = invitacion.Tipo;


                invitacionNH.Estado = invitacion.Estado;


                invitacionNH.FechaEnvio = invitacion.FechaEnvio;





                session.Update (invitacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in InvitacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (InvitacionEN invitacion)
{
        InvitacionNH invitacionNH = new InvitacionNH (invitacion);

        try
        {
                SessionInitializeTransaction ();
                if (invitacion.Comunidad != null) {
                        // Argumento OID y no colección.
                        invitacionNH
                        .Comunidad = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN), invitacion.Comunidad.Id);

                        invitacionNH.Comunidad.Invitacion
                                = invitacionNH;
                }
                if (invitacion.Emisor != null) {
                        // Argumento OID y no colección.
                        invitacionNH
                        .Emisor = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN), invitacion.Emisor.Id);

                        invitacionNH.Emisor.InvitacionEmisor
                        .Add (invitacionNH);
                }

                session.Save (invitacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in InvitacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return invitacionNH.Id;
}

public void Modify (InvitacionEN invitacion)
{
        try
        {
                SessionInitializeTransaction ();
                InvitacionNH invitacionNH = (InvitacionNH)session.Load (typeof(InvitacionNH), invitacion.Id);

                invitacionNH.Tipo = invitacion.Tipo;


                invitacionNH.Estado = invitacion.Estado;


                invitacionNH.FechaEnvio = invitacion.FechaEnvio;

                session.Update (invitacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in InvitacionRepository.", ex);
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
                InvitacionNH invitacionNH = (InvitacionNH)session.Load (typeof(InvitacionNH), id);
                session.Delete (invitacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in InvitacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: InvitacionEN
public InvitacionEN ReadOID (int id
                             )
{
        InvitacionEN invitacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                invitacionEN = (InvitacionEN)session.Get (typeof(InvitacionNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return invitacionEN;
}

public System.Collections.Generic.IList<InvitacionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<InvitacionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(InvitacionNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<InvitacionEN>();
                else
                        result = session.CreateCriteria (typeof(InvitacionNH)).List<InvitacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in InvitacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
