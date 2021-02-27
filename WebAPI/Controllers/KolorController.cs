using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class KolorsController : ControllerBase
        {
            IKolorService _kolorService;

            public KolorsController(IKolorService kolorService)
            {
                _kolorService = kolorService;
            }

            [HttpGet("getall")]
            public IActionResult GetAll()
            {
                var result = _kolorService.GetAll();
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            [HttpGet("getbyid")]
            public IActionResult GetById(int id)
            {
                var result = _kolorService.GetById(id);
                if (result.Success)
                {
                    return Ok(result.Data);
                }
                return BadRequest(result);
            }


            [HttpPost("add")]
            public IActionResult Add(Kolor kolor)
            {
                var result = _kolorService.Add(kolor);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            [HttpPost("delete")]
            public IActionResult Delete(Kolor kolor)
            {
                var result = _kolorService.Delete(kolor);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            [HttpPost("update")]
            public IActionResult Update(Kolor kolor)
            {
                var result = _kolorService.Update(kolor);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }


        }
    }

