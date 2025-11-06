
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
 * Clase ChatEquipo:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class ChatEquipoRepository : BasicRepository, IChatEquipoRepository
{
public ChatEquipoRepository() : base ()
{
}


public ChatEquipoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public ChatEquipoEN ReadOIDDefault (int id
                                    )
{
        ChatEquipoEN chatEquipoEN = null;

        try
        {
                SessionInitializeTransaction ();
                chatEquipoEN = (ChatEquipoEN)session.Get (typeof(ChatEquipoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return chatEquipoEN;
}

public System.Collections.Generic.IList<ChatEquipoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ChatEquipoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ChatEquipoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<ChatEquipoEN>();
                        else
                                result = session.CreateCriteria (typeof(ChatEquipoNH)).List<ChatEquipoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ChatEquipoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ChatEquipoEN chatEquipo)
{
        try
        {
                SessionInitializeTransaction ();
                ChatEquipoNH chatEquipoNH = (ChatEquipoNH)session.Load (typeof(ChatEquipoNH), chatEquipo.Id);


                session.Update (chatEquipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ChatEquipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ChatEquipoEN chatEquipo)
{
        ChatEquipoNH chatEquipoNH = new ChatEquipoNH (chatEquipo);

        try
        {
                SessionInitializeTransaction ();
                if (chatEquipo.Equipo != null) {
                        for (int i = 0; i < chatEquipo.Equipo.Count; i++) {
                                chatEquipo.Equipo [i] = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN), chatEquipo.Equipo [i].Id);
                                chatEquipo.Equipo [i].ChatEquipo = chatEquipo;
                        }
                }

                session.Save (chatEquipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ChatEquipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return chatEquipoNH.Id;
}

public void Modify (ChatEquipoEN chatEquipo)
{
        try
        {
                SessionInitializeTransaction ();
                ChatEquipoNH chatEquipoNH = (ChatEquipoNH)session.Load (typeof(ChatEquipoNH), chatEquipo.Id);
                session.Update (chatEquipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ChatEquipoRepository.", ex);
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
                ChatEquipoNH chatEquipoNH = (ChatEquipoNH)session.Load (typeof(ChatEquipoNH), id);
                session.Delete (chatEquipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ChatEquipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ChatEquipoEN
public ChatEquipoEN ReadOID (int id
                             )
{
        ChatEquipoEN chatEquipoEN = null;

        try
        {
                SessionInitializeTransaction ();
                chatEquipoEN = (ChatEquipoEN)session.Get (typeof(ChatEquipoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return chatEquipoEN;
}

public System.Collections.Generic.IList<ChatEquipoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ChatEquipoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ChatEquipoNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<ChatEquipoEN>();
                else
                        result = session.CreateCriteria (typeof(ChatEquipoNH)).List<ChatEquipoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in ChatEquipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
