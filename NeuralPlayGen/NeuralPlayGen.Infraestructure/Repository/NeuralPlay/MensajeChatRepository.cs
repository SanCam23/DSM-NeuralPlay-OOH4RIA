
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
 * Clase MensajeChat:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class MensajeChatRepository : BasicRepository, IMensajeChatRepository
{
public MensajeChatRepository() : base ()
{
}


public MensajeChatRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public MensajeChatEN ReadOIDDefault (int id
                                     )
{
        MensajeChatEN mensajeChatEN = null;

        try
        {
                SessionInitializeTransaction ();
                mensajeChatEN = (MensajeChatEN)session.Get (typeof(MensajeChatNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return mensajeChatEN;
}

public System.Collections.Generic.IList<MensajeChatEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MensajeChatEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MensajeChatNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<MensajeChatEN>();
                        else
                                result = session.CreateCriteria (typeof(MensajeChatNH)).List<MensajeChatEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MensajeChatRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MensajeChatEN mensajeChat)
{
        try
        {
                SessionInitializeTransaction ();
                MensajeChatNH mensajeChatNH = (MensajeChatNH)session.Load (typeof(MensajeChatNH), mensajeChat.Id);

                mensajeChatNH.Contenido = mensajeChat.Contenido;


                mensajeChatNH.FechaEnvio = mensajeChat.FechaEnvio;



                session.Update (mensajeChatNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MensajeChatRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (MensajeChatEN mensajeChat)
{
        MensajeChatNH mensajeChatNH = new MensajeChatNH (mensajeChat);

        try
        {
                SessionInitializeTransaction ();
                if (mensajeChat.ChatEquipo != null) {
                        // Argumento OID y no colección.
                        mensajeChatNH
                        .ChatEquipo = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ChatEquipoEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ChatEquipoEN), mensajeChat.ChatEquipo.Id);

                        mensajeChatNH.ChatEquipo.MensajeChat
                        .Add (mensajeChatNH);
                }
                if (mensajeChat.Usuario != null) {
                        // Argumento OID y no colección.
                        mensajeChatNH
                        .Usuario = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN), mensajeChat.Usuario.Id);

                        mensajeChatNH.Usuario.MensajeChat
                        .Add (mensajeChatNH);
                }

                session.Save (mensajeChatNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MensajeChatRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mensajeChatNH.Id;
}

public void Modify (MensajeChatEN mensajeChat)
{
        try
        {
                SessionInitializeTransaction ();
                MensajeChatNH mensajeChatNH = (MensajeChatNH)session.Load (typeof(MensajeChatNH), mensajeChat.Id);

                mensajeChatNH.Contenido = mensajeChat.Contenido;


                mensajeChatNH.FechaEnvio = mensajeChat.FechaEnvio;

                session.Update (mensajeChatNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MensajeChatRepository.", ex);
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
                MensajeChatNH mensajeChatNH = (MensajeChatNH)session.Load (typeof(MensajeChatNH), id);
                session.Delete (mensajeChatNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MensajeChatRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: MensajeChatEN
public MensajeChatEN ReadOID (int id
                              )
{
        MensajeChatEN mensajeChatEN = null;

        try
        {
                SessionInitializeTransaction ();
                mensajeChatEN = (MensajeChatEN)session.Get (typeof(MensajeChatNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return mensajeChatEN;
}

public System.Collections.Generic.IList<MensajeChatEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MensajeChatEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MensajeChatNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<MensajeChatEN>();
                else
                        result = session.CreateCriteria (typeof(MensajeChatNH)).List<MensajeChatEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in MensajeChatRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
