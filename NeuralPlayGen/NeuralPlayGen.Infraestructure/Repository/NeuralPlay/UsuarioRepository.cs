
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
 * Clase Usuario:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class UsuarioRepository : BasicRepository, IUsuarioRepository
{
public UsuarioRepository() : base ()
{
}


public UsuarioRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public UsuarioEN ReadOIDDefault (int id
                                 )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioNH)).List<UsuarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioNH usuarioNH = (UsuarioNH)session.Load (typeof(UsuarioNH), usuario.Id);

                usuarioNH.Pass = usuario.Pass;


                usuarioNH.Nick = usuario.Nick;


                usuarioNH.CorreoElectronico = usuario.CorreoElectronico;


                usuarioNH.Telefono = usuario.Telefono;


                usuarioNH.FechaRegistro = usuario.FechaRegistro;


                usuarioNH.EstadoCuenta = usuario.EstadoCuenta;















                session.Update (usuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (UsuarioEN usuario)
{
        UsuarioNH usuarioNH = new UsuarioNH (usuario);

        try
        {
                SessionInitializeTransaction ();
                if (usuario.Perfil != null) {
                        // Argumento OID y no colección.
                        usuarioNH
                        .Perfil = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN), usuario.Perfil.Id);

                        usuarioNH.Perfil.Usuario
                                = usuarioNH;
                }

                session.Save (usuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioNH.Id;
}

public void Modify (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioNH usuarioNH = (UsuarioNH)session.Load (typeof(UsuarioNH), usuario.Id);

                usuarioNH.Pass = usuario.Pass;


                usuarioNH.Nick = usuario.Nick;


                usuarioNH.CorreoElectronico = usuario.CorreoElectronico;


                usuarioNH.Telefono = usuario.Telefono;


                usuarioNH.FechaRegistro = usuario.FechaRegistro;


                usuarioNH.EstadoCuenta = usuario.EstadoCuenta;

                session.Update (usuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
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
                UsuarioNH usuarioNH = (UsuarioNH)session.Load (typeof(UsuarioNH), id);
                session.Delete (usuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: UsuarioEN
public UsuarioEN ReadOID (int id
                          )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(UsuarioNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                else
                        result = session.CreateCriteria (typeof(UsuarioNH)).List<UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN> DameUsuariosPorEquipo (int ? u_idEquipo)
{
        System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioNH self where select u FROM UsuarioNH as u inner join u.MiembroEquipo as mem where mem.Equipo.id = :u_idEquipo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioNHdameUsuariosPorEquipoHQL");
                query.SetParameter ("u_idEquipo", u_idEquipo);

                result = query.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN> DameUsuariosPorComunidad (int ? u_idComunidad)
{
        System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioNH self where select u FROM UsuarioNH as u inner join u.MiembroComunidad as mem where mem.Comunidad.id = :u_idComunidad";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioNHdameUsuariosPorComunidadHQL");
                query.SetParameter ("u_idComunidad", u_idComunidad);

                result = query.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
