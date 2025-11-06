

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class PropuestaTorneoCEN
 *
 */
public partial class PropuestaTorneoCEN
{
private IPropuestaTorneoRepository _IPropuestaTorneoRepository;

public PropuestaTorneoCEN(IPropuestaTorneoRepository _IPropuestaTorneoRepository)
{
        this._IPropuestaTorneoRepository = _IPropuestaTorneoRepository;
}

public IPropuestaTorneoRepository get_IPropuestaTorneoRepository ()
{
        return this._IPropuestaTorneoRepository;
}

public int New_ (Nullable<DateTime> p_fechaPropuesta, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum p_estado, int p_torneo, int p_equipo, int p_usuario, string p_nombre)
{
        PropuestaTorneoEN propuestaTorneoEN = null;
        int oid;

        //Initialized PropuestaTorneoEN
        propuestaTorneoEN = new PropuestaTorneoEN ();
        propuestaTorneoEN.FechaPropuesta = p_fechaPropuesta;

        propuestaTorneoEN.Estado = p_estado;


        if (p_torneo != -1) {
                // El argumento p_torneo -> Property torneo es oid = false
                // Lista de oids id
                propuestaTorneoEN.Torneo = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN ();
                propuestaTorneoEN.Torneo.Id = p_torneo;
        }


        if (p_equipo != -1) {
                // El argumento p_equipo -> Property equipo es oid = false
                // Lista de oids id
                propuestaTorneoEN.Equipo = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN ();
                propuestaTorneoEN.Equipo.Id = p_equipo;
        }


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                propuestaTorneoEN.Usuario = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN ();
                propuestaTorneoEN.Usuario.Id = p_usuario;
        }

        propuestaTorneoEN.Nombre = p_nombre;



        oid = _IPropuestaTorneoRepository.New_ (propuestaTorneoEN);
        return oid;
}

public void Modify (int p_PropuestaTorneo_OID, Nullable<DateTime> p_fechaPropuesta, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum p_estado, string p_nombre)
{
        PropuestaTorneoEN propuestaTorneoEN = null;

        //Initialized PropuestaTorneoEN
        propuestaTorneoEN = new PropuestaTorneoEN ();
        propuestaTorneoEN.Id = p_PropuestaTorneo_OID;
        propuestaTorneoEN.FechaPropuesta = p_fechaPropuesta;
        propuestaTorneoEN.Estado = p_estado;
        propuestaTorneoEN.Nombre = p_nombre;
        //Call to PropuestaTorneoRepository

        _IPropuestaTorneoRepository.Modify (propuestaTorneoEN);
}

public void Destroy (int id
                     )
{
        _IPropuestaTorneoRepository.Destroy (id);
}

public PropuestaTorneoEN ReadOID (int id
                                  )
{
        PropuestaTorneoEN propuestaTorneoEN = null;

        propuestaTorneoEN = _IPropuestaTorneoRepository.ReadOID (id);
        return propuestaTorneoEN;
}

public System.Collections.Generic.IList<PropuestaTorneoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PropuestaTorneoEN> list = null;

        list = _IPropuestaTorneoRepository.ReadAll (first, size);
        return list;
}
}
}
