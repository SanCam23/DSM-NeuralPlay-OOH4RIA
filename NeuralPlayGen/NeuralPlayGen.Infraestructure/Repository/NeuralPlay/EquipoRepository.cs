
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
 * Clase Equipo:
 *
 */

namespace NeuralPlayGen.Infraestructure.Repository.NeuralPlay
{
public partial class EquipoRepository : BasicRepository, IEquipoRepository
{
public EquipoRepository() : base ()
{
}


public EquipoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public EquipoEN ReadOIDDefault (int id
                                )
{
        EquipoEN equipoEN = null;

        try
        {
                SessionInitializeTransaction ();
                equipoEN = (EquipoEN)session.Get (typeof(EquipoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return equipoEN;
}

public System.Collections.Generic.IList<EquipoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EquipoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EquipoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<EquipoEN>();
                        else
                                result = session.CreateCriteria (typeof(EquipoNH)).List<EquipoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in EquipoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EquipoEN equipo)
{
        try
        {
                SessionInitializeTransaction ();
                EquipoNH equipoNH = (EquipoNH)session.Load (typeof(EquipoNH), equipo.Id);

                equipoNH.Nombre = equipo.Nombre;


                equipoNH.Descripcion = equipo.Descripcion;


                equipoNH.FechaCreacion = equipo.FechaCreacion;









                session.Update (equipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in EquipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (EquipoEN equipo)
{
        EquipoNH equipoNH = new EquipoNH (equipo);

        try
        {
                SessionInitializeTransaction ();
                if (equipo.Comunidad != null) {
                        // Argumento OID y no colección.
                        equipoNH
                        .Comunidad = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN), equipo.Comunidad.Id);

                        equipoNH.Comunidad.Equipo
                        .Add (equipoNH);
                }
                if (equipo.Juego != null) {
                        for (int i = 0; i < equipo.Juego.Count; i++) {
                                equipo.Juego [i] = (NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN)session.Load (typeof(NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN), equipo.Juego [i].Id);
                                equipo.Juego [i].Equipo.Add (equipoNH);
                        }
                }

                session.Save (equipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in EquipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return equipoNH.Id;
}

public void Modify (EquipoEN equipo)
{
        try
        {
                SessionInitializeTransaction ();
                EquipoNH equipoNH = (EquipoNH)session.Load (typeof(EquipoNH), equipo.Id);

                equipoNH.Nombre = equipo.Nombre;


                equipoNH.Descripcion = equipo.Descripcion;


                equipoNH.FechaCreacion = equipo.FechaCreacion;

                session.Update (equipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in EquipoRepository.", ex);
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
                EquipoNH equipoNH = (EquipoNH)session.Load (typeof(EquipoNH), id);
                session.Delete (equipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in EquipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: EquipoEN
public EquipoEN ReadOID (int id
                         )
{
        EquipoEN equipoEN = null;

        try
        {
                SessionInitializeTransaction ();
                equipoEN = (EquipoEN)session.Get (typeof(EquipoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return equipoEN;
}

public System.Collections.Generic.IList<EquipoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EquipoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(EquipoNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<EquipoEN>();
                else
                        result = session.CreateCriteria (typeof(EquipoNH)).List<EquipoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NeuralPlayGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new NeuralPlayGen.ApplicationCore.Exceptions.DataLayerException ("Error in EquipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
