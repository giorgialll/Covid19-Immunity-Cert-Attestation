﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Covid19ImmunityCert.Application
{
    public class TestBrokerConsole
    {
        public static async Task ExecuteSampleRun()
        {
            var url = "http://testchain.nethereum.com:8545";
            //var url = "https://mainnet.infura.io";
            var contractAddress = "somekindofaddress";
            var privateKey = "0x7580e7fb49df1c861f0050fae31c2224c6aba908e116b8da44ee8cd927b990b0";
            var account = new Nethereum.Web3.Accounts.Account(privateKey);
            var web3 = new Web3(account, url);
            
             /* Deployment 
            var testBrokerDeployment = new TestBrokerDeployment();

            var transactionReceiptDeployment = await web3.Eth.GetContractDeploymentHandler<TestBrokerDeployment>().SendRequestAndWaitForReceiptAsync(testBrokerDeployment);
            var contractAddress = transactionReceiptDeployment.ContractAddress;
             */ 
            var contractHandler = web3.Eth.GetContractHandler(contractAddress);

            /** Function: addSampleCentre**/
            /*
            var addSampleCentreFunction = new AddSampleCentreFunction();
            addSampleCentreFunction.NewCentre = newCentre;
            var addSampleCentreFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(addSampleCentreFunction);
            */


            /** Function: addSampleCentreToLocationCache**/
            /*

            */


            /** Function: addTestingAffiliation**/
            /*
            var addTestingAffiliationFunction = new AddTestingAffiliationFunction();
            addTestingAffiliationFunction.SampleCentreId = sampleCentreId;
            addTestingAffiliationFunction.TestCentreId = testCentreId;
            addTestingAffiliationFunction.InsuranceGrp = insuranceGrp;
            var addTestingAffiliationFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(addTestingAffiliationFunction);
            */


            /** Function: getSampleCentre**/
            /*
            var getSampleCentreFunction = new GetSampleCentreFunction(); 
            getSampleCentreFunction.SampleCentreId = sampleCentreId;
            var getSampleCentreOutputDTO = await contractHandler.QueryDeserializingToObjectAsync<GetSampleCentreFunction, GetSampleCentreOutputDTO>(getSampleCentreFunction);
            */


            /** Function: getSampleCentresWithAvailableTests**/
            /*
            var getSampleCentresWithAvailableTestsFunction = new GetSampleCentresWithAvailableTestsFunction(); 
            getSampleCentresWithAvailableTestsFunction.MinWaitTimeInDays = minWaitTimeInDays;
            var getSampleCentresWithAvailableTestsOutputDTO = await contractHandler.QueryDeserializingToObjectAsync<GetSampleCentresWithAvailableTestsFunction, GetSampleCentresWithAvailableTestsOutputDTO>(getSampleCentresWithAvailableTestsFunction);
            */


            /** Function: updateSampleCentre**/
            /*
            var updateSampleCentreFunction = new UpdateSampleCentreFunction();
            updateSampleCentreFunction.UpdateCentre = updateCentre;
            var updateSampleCentreFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(updateSampleCentreFunction);
            */
        }

    }

    public partial class TestBrokerDeployment : TestBrokerDeploymentBase
    {
        public TestBrokerDeployment() : base(BYTECODE) { }
        public TestBrokerDeployment(string byteCode) : base(byteCode) { }
    }

    public class TestBrokerDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801561001057600080fd5b50600436106100625760003560e01c8063041c2e54146100675780632343873f1461007c57806345100135146100a5578063554cdc34146100c55780635fc5e22b146100d8578063cc806bea146100eb575b600080fd5b61007a610075366004610c5c565b6100fe565b005b61008f61008a366004610c19565b6102b6565b60405161009c9190610f76565b60405180910390f35b6100b86100b3366004610d21565b6103b6565b60405161009c9190610e36565b61007a6100d3366004610c31565b6108b8565b61007a6100e6366004610c5c565b610934565b61007a6100f9366004610c5c565b610aa8565b6005546001600160a01b031633146101315760405162461bcd60e51b815260040161012890610e85565b60405180910390fd5b60408082015160009081526003602052206006015460ff1615156001141561016b5760405162461bcd60e51b815260040161012890610ef4565b60408181018051600280546001808201835560008381527f405787fa12a823e0f2b7631cc41b3ba8828b3321ca811111fa75cd3aa3bb5ace90920193909355835181526003602081815295909120865181558587015193810180546001600160a01b0319166001600160a01b039095169490941790935592519082015560608401519181018054608086015160a087015160c088015160e089015160ff199485169715159790971762ffff00191661010061ffff9094168402176affffffffffffffff000000191663010000006001600160401b03938416021767ffffffffffffffff60581b1916600160581b92909116919091021760ff60981b1916600160981b60ff90961695909502949094179091559184015180516004830155909201516005830155610120830151600690920180549091169115159190911790556102b381610aa8565b50565b6102be610b0c565b60008281526003602052604090206006015460ff1615156001146102f45760405162461bcd60e51b815260040161012890610f35565b506000908152600360208181526040928390208351610140810185528154815260018201546001600160a01b0316818401526002820154818601529281015460ff8082161515606086015261010080830461ffff166080870152630100000083046001600160401b0390811660a0880152600160581b84041660c0870152600160981b909204811660e0860152855180870190965260048301548652600583015493860193909352830193909352600690920154909116151561012082015290565b60606000805b60025460ff821610156104bc5760006003600060028460ff16815481106103df57fe5b9060005260206000200154815260200190815260200160002060030160039054906101000a90046001600160401b03166001600160401b031611801561045757506003600060028360ff168154811061043457fe5b6000918252602080832090910154835282019290925260400190206003015460ff165b80156104a857508361ffff166003600060028460ff168154811061047757fe5b9060005260206000200154815260200190815260200160002060030160019054906101000a900461ffff1661ffff16115b156104b4576001909101905b6001016103bc565b506060816001600160401b03811180156104d557600080fd5b5060405190808252806020026020018201604052801561050f57816020015b6104fc610b0c565b8152602001906001900390816104f45790505b50905060005b60025460ff821610156108b05760006003600060028460ff168154811061053857fe5b9060005260206000200154815260200190815260200160002060030160039054906101000a90046001600160401b03166001600160401b03161180156105b057506003600060028360ff168154811061058d57fe5b6000918252602080832090910154835282019290925260400190206003015460ff165b156108a8576040518061014001604052806003600060028560ff16815481106105d557fe5b906000526020600020015481526020019081526020016000206000015481526020016003600060028560ff168154811061060b57fe5b9060005260206000200154815260200190815260200160002060010160009054906101000a90046001600160a01b03166001600160a01b031681526020016003600060028560ff168154811061065d57fe5b906000526020600020015481526020019081526020016000206002015481526020016003600060028560ff168154811061069357fe5b9060005260206000200154815260200190815260200160002060030160009054906101000a900460ff16151581526020016003600060028560ff16815481106106d857fe5b9060005260206000200154815260200190815260200160002060030160019054906101000a900461ffff1661ffff1681526020016003600060028560ff168154811061072057fe5b9060005260206000200154815260200190815260200160002060030160039054906101000a90046001600160401b03166001600160401b031681526020016003600060028560ff168154811061077257fe5b90600052602060002001548152602001908152602001600020600301600b9054906101000a90046001600160401b03166001600160401b031681526020016003600060028560ff16815481106107c457fe5b9060005260206000200154815260200190815260200160002060030160139054906101000a900460ff1660ff1681526020016003600060028560ff168154811061080a57fe5b906000526020600020015481526020019081526020016000206004016040518060400160405290816000820154815260200160018201548152505081526020016003600060028560ff168154811061085e57fe5b9060005260206000200154815260200190815260200160002060060160009054906101000a900460ff161515815250828260ff168151811061089c57fe5b60200260200101819052505b600101610515565b509392505050565b6005546001600160a01b031633146108e25760405162461bcd60e51b815260040161012890610e85565b60008381526003602052604090206006015460ff1615156001146109185760405162461bcd60e51b815260040161012890610f35565b6000928352600460209081526040808520938552929052912055565b6005546001600160a01b0316331461095e5760405162461bcd60e51b815260040161012890610e85565b60408082015160009081526003602052206006015460ff1615156001146109975760405162461bcd60e51b815260040161012890610f35565b60208181015160408084018051600090815260039485905282812060010180546001600160a01b0319166001600160a01b03909516949094179093556060850151815184528284208501805460ff19169115159190911790556080850151815184528284208501805462ffff00191661010061ffff9093169290920291909117905560a085015181518452828420850180546affffffffffffffff000000191663010000006001600160401b039384160217905560c0860151825185528385208601805467ffffffffffffffff60581b1916600160581b929093169190910291909117905560e09094015193518252902001805460ff60981b1916600160981b60ff90931692909202919091179055565b6005546001600160a01b03163314610ad25760405162461bcd60e51b815260040161012890610e85565b60408082015160009081526003602052206006015460ff161515600114156102b35760405162461bcd60e51b815260040161012890610ef4565b6040805161014081018252600080825260208201819052918101829052606081018290526080810182905260a0810182905260c0810182905260e08101919091526101008101610b5a610b67565b8152600060209091015290565b604051806040016040528060008152602001600081525090565b80356001600160a01b0381168114610b9857600080fd5b92915050565b80358015158114610b9857600080fd5b600060408284031215610bbf578081fd5b610bc96040610f85565b9050813581526020820135602082015292915050565b803561ffff81168114610b9857600080fd5b80356001600160401b0381168114610b9857600080fd5b803560ff81168114610b9857600080fd5b600060208284031215610c2a578081fd5b5035919050565b600080600060608486031215610c45578182fd5b505081359360208301359350604090920135919050565b60006101608284031215610c6e578081fd5b610140610c7a81610f85565b83358152610c8b8560208601610b81565b602082015260408401356040820152610ca78560608601610b9e565b6060820152610cb98560808601610bdf565b6080820152610ccb8560a08601610bf1565b60a0820152610cdd8560c08601610bf1565b60c0820152610cef8560e08601610c08565b60e0820152610100610d0386828701610bae565b90820152610d1385858401610b9e565b610120820152949350505050565b600060208284031215610d32578081fd5b813561ffff81168114610d43578182fd5b9392505050565b6001600160a01b03169052565b15159052565b80518252602090810151910152565b805182526020810151610d826020840182610d4a565b50604081015160408301526060810151610d9f6060840182610d57565b506080810151610db26080840182610e1a565b5060a0810151610dc560a0840182610e22565b5060c0810151610dd860c0840182610e22565b5060e0810151610deb60e0840182610e2f565b5061010080820151610dff82850182610d5d565b5050610120810151610e15610140840182610d57565b505050565b61ffff169052565b6001600160401b03169052565b60ff169052565b6020808252825182820181905260009190848201906040850190845b81811015610e7957610e65838551610d6c565b928401926101609290920191600101610e52565b50909695505050505050565b60208082526049908201527f5468652063616c6c6572206f662074686973206d6574686f6420646f6573206e60408201527f6f7420686176652061646d696e207065726d697373696f6e20666f7220746869606082015268399030b1ba34b7b71760b91b608082015260a00190565b60208082526021908201527f5468652073616d706c652063656e74726520616c7265616479206578697374736040820152601760f91b606082015260800190565b60208082526021908201527f5468652073616d706c652063656e74726520646f6573206e6f742065786973746040820152601760f91b606082015260800190565b6101608101610b988284610d6c565b6040518181016001600160401b0381118282101715610fa357600080fd5b60405291905056fea26469706673582212207d8a6b35ed5b115a9598b8a906831363e4535363ba07484879bbb60d3393d7d864736f6c63430006060033";
        public TestBrokerDeploymentBase() : base(BYTECODE) { }
        public TestBrokerDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class AddSampleCentreFunction : AddSampleCentreFunctionBase { }

    [Function("addSampleCentre")]
    public class AddSampleCentreFunctionBase : FunctionMessage
    {
        [Parameter("tuple", "newCentre", 1)]
        public virtual SampleCentre NewCentre { get; set; }
    }

    public partial class AddSampleCentreToLocationCacheFunction : AddSampleCentreToLocationCacheFunctionBase { }

    [Function("addSampleCentreToLocationCache")]
    public class AddSampleCentreToLocationCacheFunctionBase : FunctionMessage
    {
        [Parameter("tuple", "newCentre", 1)]
        public virtual SampleCentre NewCentre { get; set; }
    }

    public partial class AddTestingAffiliationFunction : AddTestingAffiliationFunctionBase { }

    [Function("addTestingAffiliation")]
    public class AddTestingAffiliationFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "sampleCentreId", 1)]
        public virtual byte[] SampleCentreId { get; set; }
        [Parameter("bytes32", "testCentreId", 2)]
        public virtual byte[] TestCentreId { get; set; }
        [Parameter("bytes32", "insuranceGrp", 3)]
        public virtual byte[] InsuranceGrp { get; set; }
    }

    public partial class GetSampleCentreFunction : GetSampleCentreFunctionBase { }

    [Function("getSampleCentre", typeof(GetSampleCentreOutputDTO))]
    public class GetSampleCentreFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "sampleCentreId", 1)]
        public virtual byte[] SampleCentreId { get; set; }
    }

    public partial class GetSampleCentresWithAvailableTestsFunction : GetSampleCentresWithAvailableTestsFunctionBase { }

    [Function("getSampleCentresWithAvailableTests", typeof(GetSampleCentresWithAvailableTestsOutputDTO))]
    public class GetSampleCentresWithAvailableTestsFunctionBase : FunctionMessage
    {
        [Parameter("uint16", "minWaitTimeInDays", 1)]
        public virtual ushort MinWaitTimeInDays { get; set; }
    }

    public partial class UpdateSampleCentreFunction : UpdateSampleCentreFunctionBase { }

    [Function("updateSampleCentre")]
    public class UpdateSampleCentreFunctionBase : FunctionMessage
    {
        [Parameter("tuple", "updateCentre", 1)]
        public virtual SampleCentre UpdateCentre { get; set; }
    }

    public partial class GetSampleCentreOutputDTO : GetSampleCentreOutputDTOBase { }

    [FunctionOutput]
    public class GetSampleCentreOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual SampleCentre ReturnValue1 { get; set; }
    }

    public partial class GetSampleCentresWithAvailableTestsOutputDTO : GetSampleCentresWithAvailableTestsOutputDTOBase { }

    [FunctionOutput]
    public class GetSampleCentresWithAvailableTestsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple[]", "", 1)]
        public virtual List<SampleCentre> ReturnValue1 { get; set; }
    }

    public partial class Coordinates : CoordinatesBase { }

    public class CoordinatesBase 
    {
        [Parameter("uint256", "lat", 1)]
        public virtual BigInteger Lat { get; set; }
        [Parameter("uint256", "long", 2)]
        public virtual BigInteger Long { get; set; }
    }

    public partial class SampleCentre : SampleCentreBase { }

    public class SampleCentreBase 
    {
        [Parameter("uint256", "centreId", 1)]
        public virtual BigInteger CentreId { get; set; }
        [Parameter("address", "centreAcct", 2)]
        public virtual string CentreAcct { get; set; }
        [Parameter("bytes32", "centreName", 3)]
        public virtual byte[] CentreName { get; set; }
        [Parameter("bool", "isActive", 4)]
        public virtual bool IsActive { get; set; }
        [Parameter("uint16", "avgTimeForResultsInDays", 5)]
        public virtual ushort AvgTimeForResultsInDays { get; set; }
        [Parameter("uint64", "availabileTestSlots", 6)]
        public virtual ulong AvailabileTestSlots { get; set; }
        [Parameter("uint64", "capacityTestSlots", 7)]
        public virtual ulong CapacityTestSlots { get; set; }
        [Parameter("uint8", "hotZoneLevel", 8)]
        public virtual byte HotZoneLevel { get; set; }
        [Parameter("tuple", "location", 9)]
        public virtual Coordinates Location { get; set; }
        [Parameter("bool", "isValue", 10)]
        public virtual bool IsValue { get; set; }
    }
}

