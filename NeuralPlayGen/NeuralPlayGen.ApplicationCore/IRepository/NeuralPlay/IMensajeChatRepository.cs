
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface IMensajeChatRepository
{
void setSessionCP (GenericSessionCP session);

MensajeChatEN ReadOIDDefault (int id
                              );

void ModifyDefault (MensajeChatEN mensajeChat);

System.Collections.Generic.IList<MensajeChatEN> ReadAllDefault (int first, int size);



int New_ (MensajeChatEN mensajeChat);

void Modify (MensajeChatEN mensajeChat);


void Destroy (int id
              );


MensajeChatEN ReadOID (int id
                       );


System.Collections.Generic.IList<MensajeChatEN> ReadAll (int first, int size);
}
}
