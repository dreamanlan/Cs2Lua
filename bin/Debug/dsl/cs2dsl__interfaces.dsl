interface(DataBlockDefine.IDataBlock) { interfaces {}; };
interface(DataBlockDefine.IFinalizableDataBlock) { interfaces {"DataBlockDefine.IDataBlock"}; };
interface(DataBlockDefine.IJceProto) { interfaces {"DataBlockDefine.IFinalizableDataBlock"; "DataBlockDefine.IDataBlock"}; };
