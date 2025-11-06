

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class SolicitudIngresoCEN
 *
 */
public partial class SolicitudIngresoCEN
{
private ISolicitudIngresoRepository _ISolicitudIngresoRepository;

public SolicitudIngresoCEN(ISolicitudIngresoRepository _ISolicitudIngresoRepository)
{
        this._ISolicitudIngresoRepository = _ISolicitudIngresoRepository;
}

public ISolicitudIngresoRepository get_ISolicitudIngresoRepository ()
{
        return this._ISolicitudIngresoRepository;
}

public int New_ (NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoInvitacionEnum p_tipo, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum p_estado, Nullable<DateTime> p_fechaSolicitud, int p_comunidad, int p_usuario)
{
        SolicitudIngresoEN solicitudIngresoEN = null;
        int oid;

        //Initialized SolicitudIngresoEN
        solicitudIngresoEN = new SolicitudIngresoEN ();
        solicitudIngresoEN.Tipo = p_tipo;

        solicitudIngresoEN.Estado = p_estado;

        solicitudIngresoEN.FechaSolicitud = p_fechaSolicitud;


        if (p_comunidad != -1) {
                // El argumento p_comunidad -> Property comunidad es oid = false
                // Lista de oids id
                solicitudIngresoEN.Comunidad = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN ();
                solicitudIngresoEN.Comunidad.Id = p_comunidad;
        }


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                solicitudIngresoEN.Usuario = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN ();
                solicitudIngresoEN.Usuario.Id = p_usuario;
        }



        oid = _ISolicitudIngresoRepository.New_ (solicitudIngresoEN);
        return oid;
}

public void Modify (int p_SolicitudIngreso_OID, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoInvitacionEnum p_tipo, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum p_estado, Nullable<DateTime> p_fechaSolicitud)
{
        SolicitudIngresoEN solicitudIngresoEN = null;

        //Initialized SolicitudIngresoEN
        solicitudIngresoEN = new SolicitudIngresoEN ();
        solicitudIngresoEN.Id = p_SolicitudIngreso_OID;
        solicitudIngresoEN.Tipo = p_tipo;
        solicitudIngresoEN.Estado = p_estado;
        solicitudIngresoEN.FechaSolicitud = p_fechaSolicitud;
        //Call to SolicitudIngresoRepository

        _ISolicitudIngresoRepository.Modify (solicitudIngresoEN);
}

public void Destroy (int id
                     )
{
        _ISolicitudIngresoRepository.Destroy (id);
}

public SolicitudIngresoEN ReadOID (int id
                                   )
{
        SolicitudIngresoEN solicitudIngresoEN = null;

        solicitudIngresoEN = _ISolicitudIngresoRepository.ReadOID (id);
        return solicitudIngresoEN;
}

public System.Collections.Generic.IList<SolicitudIngresoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SolicitudIngresoEN> list = null;

        list = _ISolicitudIngresoRepository.ReadAll (first, size);
        return list;
}
}
}
