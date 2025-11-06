
using System;
using System.Text;
using System.Collections.Generic;
using NeuralPlayGen.ApplicationCore.Exceptions;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


/*PROTECTED REGION ID(usingNeuralPlayGen.ApplicationCore.CEN.NeuralPlay_Notificacion_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
public partial class NotificacionCEN
{
public int New_ (NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoNotificacionEnum p_tipo, string p_mensaje, Nullable<DateTime> p_fechaCreacion, int p_usuario)
{
        /*PROTECTED REGION ID(NeuralPlayGen.ApplicationCore.CEN.NeuralPlay_Notificacion_new__customized) START*/

        NotificacionEN notificacionEN = null;

        int oid;

        //Initialized NotificacionEN
        notificacionEN = new NotificacionEN ();
        notificacionEN.Tipo = p_tipo;

        notificacionEN.Mensaje = p_mensaje;

        notificacionEN.FechaCreacion = p_fechaCreacion;

        notificacionEN.Leida = false;


        if (p_usuario != -1) {
            notificacionEN.Usuario = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN ();
            notificacionEN.Usuario.Id = p_usuario;
        }

        //Call to NotificacionRepository

        oid = _INotificacionRepository.New_ (notificacionEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
