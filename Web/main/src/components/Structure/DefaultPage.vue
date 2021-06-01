<template>
  <div class="page">
    <div class="header">
      <NavBar/>
    </div>
    <div class="main">
      <slot></slot>
    </div>
    <div class="lf"/>
    <div class="footer">
      <p>Footer</p>
    </div>
    <div class="rf"/>
  </div>
</template>

<script>
import NavBar from '../../components/Structure/Navigation/NavBar.vue'

export default {
  name: 'DefaultPage',
    components: {
    NavBar
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .page{
    display: grid;
    min-height: 100vh;
    grid-template-columns: minmax(10px,auto) minmax(0,1280px) minmax(10px,auto);
    grid-template-rows: auto 1fr auto;
    grid-template-areas: 
    " . header ."
    ". main ."
    "lf footer rf";
    text-align: center;
    color: var(--main-dark-color);
    background: var(--main-white-color);
    font-family: Avenir, Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
  }

  .header{
    grid-area: header;
  }

  .main{
    grid-area: main;
  }

  .footer{
    grid-area: footer;
    color: var(--main-white-color);
    background: var(--main-dark-color);
  }

  .lf{
    grid-area: lf;
    background: var(--main-dark-color);
  }

  .rf{
    grid-area: rf;
    background: var(--main-dark-color);
  }

</style>
