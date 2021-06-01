<template>
  <div class="footer">
    <SocialLink 
      imageUrl="./assets/social-logos/linkedin-64.png" 
      description="Hello"/>
    <SocialLink description="Hello"/>
    <SocialLink description="Hello"/>
  </div>
</template>


<script>
import SocialLink from './SocialLink'
export default{
  name: 'Footer',
  components: {
    SocialLink
  }
}
</script>


<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .footer{
    display: flex;
    margin: 1.5em 1.0em;
    text-align: left;
  }

</style>