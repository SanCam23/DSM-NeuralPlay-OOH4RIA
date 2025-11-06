

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class NotificacionCEN
 *
 */
public partial class NotificacionCEN
{
private INotificacionRepository _INotificacionRepository;

public NotificacionCEN(INotificacionRepository _INotificacionRepository)
{
        this._INotificacionRepository = _INotificacionRepository;
}

public INotificacionRepository get_INotificacionRepository ()
{
        return this._INotificacionRepository;
}

public int New_ (NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoNotificacionEnum p_tipo, string p_mensaje, bool p_leida, Nullable<DateTime> p_fechaCreacion, int p_usuario)
{
        NotificacionEN notificacionEN = null;
        int oid;

        //Initialized NotificacionEN
        notificacionEN = new NotificacionEN ();
        notificacionEN.Tipo = p_tipo;

        notificacionEN.Mensaje = p_mensaje;

        notificacionEN.Leida = p_leida;

        notificacionEN.FechaCreacion = p_fechaCreacion;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                notificacionEN.Usuario = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN ();
                notificacionEN.Usuario.Id = p_usuario;
        }



        oid = _INotificacionRepository.New_ (notificacionEN);
        return oid;
}

public void Modify (int p_Notificacion_OID, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoNotificacionEnum p_tipo, string p_mensaje, bool p_leida, Nullable<DateTime> p_fechaCreacion)
{
        NotificacionEN notificacionEN = null;

        //Initialized NotificacionEN
        notificacionEN = new NotificacionEN ();
        notificacionEN.Id = p_Notificacion_OID;
        notificacionEN.Tipo = p_tipo;
        notificacionEN.Mensaje = p_mensaje;
        notificacionEN.Leida = p_leida;
        notificacionEN.FechaCreacion = p_fechaCreacion;
        //Call to NotificacionRepository

        _INotificacionRepository.Modify (notificacionEN);
}

public void Destroy (int id
                     )
{
        _INotificacionRepository.Destroy (id);
}

public NotificacionEN ReadOID (int id
                               )
{
        NotificacionEN notificacionEN = null;

        notificacionEN = _INotificacionRepository.ReadOID (id);
        return notificacionEN;
}

public System.Collections.Generic.IList<NotificacionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<NotificacionEN> list = null;

        list = _INotificacionRepository.ReadAll (first, size);
        return list;
}
}
}
