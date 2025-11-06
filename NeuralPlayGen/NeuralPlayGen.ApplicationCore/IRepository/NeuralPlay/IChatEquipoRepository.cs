
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface IChatEquipoRepository
{
void setSessionCP (GenericSessionCP session);

ChatEquipoEN ReadOIDDefault (int id
                             );

void ModifyDefault (ChatEquipoEN chatEquipo);

System.Collections.Generic.IList<ChatEquipoEN> ReadAllDefault (int first, int size);



int New_ (ChatEquipoEN chatEquipo);

void Modify (ChatEquipoEN chatEquipo);


void Destroy (int id
              );


ChatEquipoEN ReadOID (int id
                      );


System.Collections.Generic.IList<ChatEquipoEN> ReadAll (int first, int size);
}
}
